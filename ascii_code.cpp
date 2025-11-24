#include <iostream>

int main() {
    char symbol;
    std::cout << "Enter a symbol: ";
    std::cin >> symbol;
    int ascii_code = static_cast<int>(symbol);
    std::cout << "The ASCII code of '" << symbol << "' is: " << ascii_code << std::endl;
    return 0;
}
