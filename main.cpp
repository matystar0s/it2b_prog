#define UNICODE
#define _UNICODE
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <cmath>
#include <vector>

const int WINDOW_WIDTH = 800;
const int WINDOW_HEIGHT = 600;

struct Vec3 {
    float x, y, z;

    Vec3() : x(0), y(0), z(0) {}
    Vec3(float ix, float iy, float iz) : x(ix), y(iy), z(iz) {}

    Vec3 operator+(const Vec3& o) const {
        return Vec3(x + o.x, y + o.y, z + o.z);
    }
    Vec3 operator-(const Vec3& o) const {
        return Vec3(x - o.x, y - o.y, z - o.z);
    }
};

struct Vec2 {
    int x;
    int y;
    Vec2() : x(0), y(0) {}
    Vec2(int ix, int iy) : x(ix), y(iy) {}
};

struct Camera {
    Vec3 position;
    float yaw;   // rotation around Y axis
    float pitch; // rotation around X axis

    Camera() : position(0, 2, -5), yaw(0), pitch(0) {}
};

const Vec3 baseCubeVertices[8] = {
    Vec3(-0.5f, -0.5f, -0.5f),
    Vec3( 0.5f, -0.5f, -0.5f),
    Vec3( 0.5f,  0.5f, -0.5f),
    Vec3(-0.5f,  0.5f, -0.5f),
    Vec3(-0.5f, -0.5f,  0.5f),
    Vec3( 0.5f, -0.5f,  0.5f),
    Vec3( 0.5f,  0.5f,  0.5f),
    Vec3(-0.5f,  0.5f,  0.5f)
};

const int cubeEdges[12][2] = {
    {0,1},{1,2},{2,3},{3,0},
    {4,5},{5,6},{6,7},{7,4},
    {0,4},{1,5},{2,6},{3,7}
};

const int GRID_SIZE_X = 10;
const int GRID_SIZE_Z = 10;

LRESULT CALLBACK WindowProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
void DrawScene(HDC hdc);
Vec3 RotateY(const Vec3& v, float angle);
Vec3 RotateX(const Vec3& v, float angle);
Vec2 Project(const Vec3& v);
void GetCubeVerticesAt(const Vec3& pos, std::vector<Vec3>& outVerts);

Camera camera;
bool keys[256] = {false};

int mouseXLast = WINDOW_WIDTH / 2;
int mouseYLast = WINDOW_HEIGHT / 2;
bool mouseCaptured = false;

int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE, PWSTR, int nCmdShow);
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow) {
    return wWinMain(hInstance, hPrevInstance, GetCommandLineW(), nCmdShow);
}

Vec3 RotateY(const Vec3& v, float angle) {
    float cosA = cosf(angle);
    float sinA = sinf(angle);
    return Vec3(
        v.x * cosA + v.z * sinA,
        v.y,
        -v.x * sinA + v.z * cosA
    );
}

Vec3 RotateX(const Vec3& v, float angle) {
    float cosA = cosf(angle);
    float sinA = sinf(angle);
    return Vec3(
        v.x,
        v.y * cosA - v.z * sinA,
        v.y * sinA + v.z * cosA
    );
}

const float FOV = 256.0f;

Vec2 Project(const Vec3& v) {
    Vec3 cameraSpace = v - camera.position;
    cameraSpace = RotateY(cameraSpace, -camera.yaw);
    cameraSpace = RotateX(cameraSpace, -camera.pitch);

    if (cameraSpace.z <= 0.1f)
        return Vec2(-1000, -1000);

    float factor = FOV / cameraSpace.z;
    int x = static_cast<int>(cameraSpace.x * factor) + WINDOW_WIDTH / 2;
    int y = static_cast<int>(-cameraSpace.y * factor) + WINDOW_HEIGHT / 2;
    return Vec2(x, y);
}

void GetCubeVerticesAt(const Vec3& pos, std::vector<Vec3>& outVerts) {
    outVerts.clear();
    for (int i = 0; i < 8; i++) {
        outVerts.push_back(Vec3(
            baseCubeVertices[i].x + pos.x,
            baseCubeVertices[i].y + pos.y,
            baseCubeVertices[i].z + pos.z));
    }
}

void DrawWireframeCube(HDC hdc, const Vec3& pos) {
    std::vector<Vec3> vertices;
    GetCubeVerticesAt(pos, vertices);

    HPEN hPenOld = (HPEN)SelectObject(hdc, GetStockObject(BLACK_PEN));

    for (int i = 0; i < 12; i++) {
        Vec2 p1 = Project(vertices[cubeEdges[i][0]]);
        Vec2 p2 = Project(vertices[cubeEdges[i][1]]);

        if ((p1.x >= 0 && p1.x < WINDOW_WIDTH) && (p1.y >= 0 && p1.y < WINDOW_HEIGHT) &&
            (p2.x >= 0 && p2.x < WINDOW_WIDTH) && (p2.y >= 0 && p2.y < WINDOW_HEIGHT)) {
            MoveToEx(hdc, p1.x, p1.y, NULL);
            LineTo(hdc, p2.x, p2.y);
        }
    }

    SelectObject(hdc, hPenOld);
}

void DrawScene(HDC hdc) {
    for (int x = 0; x < GRID_SIZE_X; x++) {
        for (int z = 0; z < GRID_SIZE_Z; z++) {
            Vec3 pos(static_cast<float>(x), 0.0f, static_cast<float>(z));
            DrawWireframeCube(hdc, pos);
        }
    }
}

void DrawSceneDoubleBuffered(HWND hwnd) {
    PAINTSTRUCT ps;
    HDC hdc = BeginPaint(hwnd, &ps);

    // Create a compatible memory DC and bitmap for double buffering
    HDC memDC = CreateCompatibleDC(hdc);
    HBITMAP hBmp = CreateCompatibleBitmap(hdc, WINDOW_WIDTH, WINDOW_HEIGHT);
    HBITMAP hOldBmp = (HBITMAP)SelectObject(memDC, hBmp);

    // Fill background
    HBRUSH hBrush = (HBRUSH)(COLOR_WINDOW + 1);
    RECT rect = { 0, 0, WINDOW_WIDTH, WINDOW_HEIGHT };
    FillRect(memDC, &rect, hBrush);

    // Draw scene on memory DC
    for (int x = 0; x < GRID_SIZE_X; x++) {
        for (int z = 0; z < GRID_SIZE_Z; z++) {
            Vec3 pos(static_cast<float>(x), 0.0f, static_cast<float>(z));
            DrawWireframeCube(memDC, pos);
        }
    }

    // Blit the memory DC to the window DC
    BitBlt(hdc, 0, 0, WINDOW_WIDTH, WINDOW_HEIGHT, memDC, 0, 0, SRCCOPY);

    // Cleanup
    SelectObject(memDC, hOldBmp);
    DeleteObject(hBmp);
    DeleteDC(memDC);

    EndPaint(hwnd, &ps);
}

Vec3 operator*(const Vec3& v, float scalar) {
    return Vec3(v.x * scalar, v.y * scalar, v.z * scalar);
}

Vec3 operator*(float scalar, const Vec3& v) {
    return v * scalar;
}

void UpdateCameraPosition() {
    const float moveSpeed = 0.1f;

    Vec3 forward = Vec3(sinf(camera.yaw), 0.0f, cosf(camera.yaw));
    Vec3 right = Vec3(cosf(camera.yaw), 0.0f, -sinf(camera.yaw));

    if (keys['W']) {
        camera.position = camera.position + forward * moveSpeed;
    }
    if (keys['S']) {
        camera.position = camera.position - forward * moveSpeed;
    }
    if (keys['A']) {
        camera.position = camera.position - right * moveSpeed;
    }
    if (keys['D']) {
        camera.position = camera.position + right * moveSpeed;
    }

    camera.position.y = 1.0f;
}

LRESULT CALLBACK WindowProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam) {
    switch (uMsg) {
    case WM_PAINT: {
        // Use double-buffered drawing to reduce flickering
        DrawSceneDoubleBuffered(hwnd);
    } return 0;

    case WM_TIMER:
        UpdateCameraPosition();
        InvalidateRect(hwnd, NULL, TRUE);
        return 0;

    case WM_DESTROY:
        KillTimer(hwnd, 1);
        PostQuitMessage(0);
        return 0;

    case WM_KEYDOWN:
        keys[wParam & 0xFF] = true;
        return 0;

    case WM_KEYUP:
        keys[wParam & 0xFF] = false;
        return 0;

    case WM_MOUSEMOVE:
        if (mouseCaptured) {
            int mouseX = LOWORD(lParam);
            int mouseY = HIWORD(lParam);

            int deltaX = mouseX - mouseXLast;
            int deltaY = mouseY - mouseYLast;

            float sensitivity = 0.005f;
            camera.yaw += deltaX * sensitivity;
            camera.pitch += deltaY * sensitivity;

            if (camera.pitch > 1.5f) camera.pitch = 1.5f;
            if (camera.pitch < -1.5f) camera.pitch = -1.5f;

            RECT rect;
            GetClientRect(hwnd, &rect);
            POINT center;
            center.x = (rect.right - rect.left) / 2;
            center.y = (rect.bottom - rect.top) / 2;
            ClientToScreen(hwnd, &center);
            SetCursorPos(center.x, center.y);

            mouseXLast = center.x;
            mouseYLast = center.y;
        }
        return 0;

    case WM_SETFOCUS:
        mouseCaptured = true;
        ShowCursor(FALSE);
        {
            RECT rect;
            GetClientRect(hwnd, &rect);
            POINT center;
            center.x = (rect.right - rect.left) / 2;
            center.y = (rect.bottom - rect.top) / 2;
            ClientToScreen(hwnd, &center);
            SetCursorPos(center.x, center.y);
            mouseXLast = center.x;
            mouseYLast = center.y;
        }
        return 0;

    case WM_KILLFOCUS:
        mouseCaptured = false;
        ShowCursor(TRUE);
        return 0;

    default:
        return DefWindowProcW(hwnd, uMsg, wParam, lParam);
    }
}

int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE, PWSTR, int nCmdShow) {
    const wchar_t CLASS_NAME[] = L"Software3DRendererWindowClass";

    WNDCLASSEXW wc = { };
    wc.cbSize = sizeof(WNDCLASSEXW);
    wc.style = CS_HREDRAW | CS_VREDRAW;
    wc.lpfnWndProc = WindowProc;
    wc.hInstance = hInstance;
    wc.hCursor = LoadCursor(NULL, IDC_ARROW);
    wc.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
    wc.lpszClassName = CLASS_NAME;

    RegisterClassExW(&wc);

    HWND hwnd = CreateWindowExW(
        0,
        CLASS_NAME,
        L"3D Cube Grid Player",
        WS_OVERLAPPEDWINDOW,
        CW_USEDEFAULT, CW_USEDEFAULT,
        WINDOW_WIDTH, WINDOW_HEIGHT,
        NULL,
        NULL,
        hInstance,
        NULL
    );

    if (hwnd == NULL) {
        return 0;
    }

    ShowWindow(hwnd, nCmdShow);

    SetTimer(hwnd, 1, 30, NULL);

    MSG msg = { };
    while (GetMessageW(&msg, NULL, 0, 0)) {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }

    return 0;
}
