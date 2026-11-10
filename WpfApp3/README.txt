In WPF, you can save game progress using a file. The easiest way is to use JSON.

For example, you could save:

Player money

Player level

Upgrades

Purchased items

Progress

1. Create a class for your save data

Create a new C# class called SaveData.cs:

csharp
public class SaveData
{
    public int Money { get; set; }
    public int Level { get; set; }
    public int UpgradeLevel { get; set; }
}
2. Create a save method

In your main window:

csharp
using System.IO;
using System.Text.Json;

private void SaveGame()
{
    SaveData save = new SaveData
    {
        Money = Money,
        Level = Level,
        UpgradeLevel = UpgradeLevel
    };

    string json = JsonSerializer.Serialize(save);

    File.WriteAllText("save.json", json);
}
3. Create a load method
csharp
private void LoadGame()
{
    if (File.Exists("save.json"))
    {
        string json = File.ReadAllText("save.json");

        SaveData save = JsonSerializer.Deserialize<SaveData>(json);

        Money = save.Money;
        Level = save.Level;
        UpgradeLevel = save.UpgradeLevel;

        MoneyTextBlock.Text = Money.ToString();
    }
}
4. Automatically load progress when the game starts

Call LoadGame() inside your window constructor:

csharp
public MainWindow()
{
    InitializeComponent();
    LoadGame();
}
5. Save when the player exits
csharp
private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
{
    SaveGame();
}

Make sure your window has this event connected in XAML:

xml
Closing="Window_Closing"
What does the save file look like?

Your save.json will look something like this:

json
{
    "Money": 500,
    "Level": 3,
    "UpgradeLevel": 2
}

The next time the player opens the game, their progress will be restored!

My recommendation: Eventually, add an autosave system that saves every 30 seconds, so players don't lose progress if they forget to close the game properly.
