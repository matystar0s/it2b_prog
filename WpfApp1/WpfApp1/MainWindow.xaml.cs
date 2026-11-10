
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using clicker;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int clicks = 0;
        private int clicksAdd = 1;

        private Random random = new Random();

        private bool isOpening = false;

        private ObservableCollection<PokemonInventoryItem> Inventory =
            new ObservableCollection<PokemonInventoryItem>();

        private List<Pokemon> pokemonList = new List<Pokemon>
        {
            new Pokemon("Pidgey", PokemonRarity.Common, 10,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Pidgey.png"),

            new Pokemon("Pikachu", PokemonRarity.Uncommon, 20,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Pikachu.png"),

            new Pokemon("Charizard", PokemonRarity.Rare, 50,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Charizard.png"),

            new Pokemon("Zekrom", PokemonRarity.Legendary, 500,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Zekrom.png"),

            new Pokemon("Reshiram", PokemonRarity.Legendary, 500,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Reshiram.png"),

            new Pokemon("Mew", PokemonRarity.Mythic, 1000,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Mew.png"),

            new Pokemon("Mewtwo", PokemonRarity.Mythic, 1000,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Mewtwo.png"),

            new Pokemon("Arceus", PokemonRarity.Secret, 10000,
                @"C:\Users\xbox_\source\repos\WpfApp1\WpfApp1\images\Arceus.png")
        };

        public MainWindow()
        {
            InitializeComponent();

            PokedexList.ItemsSource = Inventory;

            UpdateStats();
        }

        private void UpdateStats()
        {
            ClickCounter.Text = "Clicks: " + clicks;
            Power.Text = "Click Power: " + clicksAdd;
        }

        private void Image_Click(object sender, MouseButtonEventArgs e)
        {
            clicks += clicksAdd;

            UpdateStats();

            DoubleAnimation animation = new DoubleAnimation
            {
                From = 1,
                To = 1.15,
                Duration = TimeSpan.FromMilliseconds(90),
                AutoReverse = true
            };

            PokeballScale.BeginAnimation(
                ScaleTransform.ScaleXProperty, animation);

            PokeballScale.BeginAnimation(
                ScaleTransform.ScaleYProperty, animation);
        }

        private void OpenEgg1_Click(object sender, MouseButtonEventArgs e)
        {
            if (isOpening)
                return;

            if (clicks < 100)
            {
                EggCost.Text = "Not enough clicks!";

                DispatcherTimer errorTimer = new DispatcherTimer
                {
                    Interval = TimeSpan.FromSeconds(1)
                };

                errorTimer.Tick += (s, args) =>
                {
                    errorTimer.Stop();
                    EggCost.Text = "100 clicks";
                };

                errorTimer.Start();

                return;
            }

            int roll = random.Next(1000000);

            PokemonRarity rarity;

            if (roll < 700000)
                rarity = PokemonRarity.Common;
            else if (roll < 900000)
                rarity = PokemonRarity.Uncommon;
            else if (roll < 980000)
                rarity = PokemonRarity.Rare;
            else if (roll < 999900)
                rarity = PokemonRarity.Legendary;
            else if (roll < 999999)
                rarity = PokemonRarity.Mythic;
            else
                rarity = PokemonRarity.Secret;

            var availablePokemon = pokemonList
                .Where(p => p.Rarity == rarity)
                .ToList();

            if (availablePokemon.Count == 0)
                return;

            Pokemon pokemon = availablePokemon[
                random.Next(availablePokemon.Count)];

            clicks -= 100;

            AddToBackpack(pokemon);

            clicksAdd += pokemon.ClickAdd;

            UpdateStats();

            PlayEggAnimation(pokemon);
        }

        private void PlayEggAnimation(Pokemon pokemon)
        {
            isOpening = true;

            DoubleAnimation shake = new DoubleAnimation
            {
                From = -15,
                To = 15,
                Duration = TimeSpan.FromMilliseconds(90),
                AutoReverse = true,
                RepeatBehavior = new RepeatBehavior(6)
            };

            shake.Completed += (s, e) =>
            {
                EggRotation.BeginAnimation(
                    RotateTransform.AngleProperty, null);

                EggRotation.Angle = 0;

                EggImage.Visibility = Visibility.Collapsed;

                RevealedPokemonImage.Source =
                    new BitmapImage(new Uri(
                        pokemon.ImagePath, UriKind.Absolute));

                RevealedPokemonName.Text = pokemon.Name;

                RevealedPokemonRarity.Text =
                    pokemon.Rarity.ToString();

                PokemonReveal.Opacity = 0;

                PokemonReveal.Visibility = Visibility.Visible;

                DoubleAnimation fadeIn = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = TimeSpan.FromMilliseconds(250)
                };

                PokemonReveal.BeginAnimation(
                    UIElement.OpacityProperty, fadeIn);

                DispatcherTimer revealTimer = new DispatcherTimer
                {
                    Interval = TimeSpan.FromSeconds(2)
                };

                revealTimer.Tick += (sender, args) =>
                {
                    revealTimer.Stop();

                    PokemonReveal.Visibility = Visibility.Collapsed;

                    EggImage.Visibility = Visibility.Visible;

                    isOpening = false;
                };

                revealTimer.Start();
            };

            EggRotation.BeginAnimation(
                RotateTransform.AngleProperty, shake);
        }

        private void AddToBackpack(Pokemon pokemon)
        {
            var existingPokemon = Inventory.FirstOrDefault(
                p => p.Name == pokemon.Name);

            if (existingPokemon != null)
            {
                existingPokemon.Count++;
            }
            else
            {
                PokemonInventoryItem newPokemon =
                    new PokemonInventoryItem(
                        pokemon.Name,
                        pokemon.Rarity,
                        1,
                        pokemon.ImagePath);

                Inventory.Add(newPokemon);
            }
        }

        private void BackpackButton_Click(
            object sender, MouseButtonEventArgs e)
        {
            PokedexOverlay.Visibility = Visibility.Visible;

            if (PokedexList.Items.Count > 0 &&
                PokedexList.SelectedItem == null)
            {
                PokedexList.SelectedIndex = 0;
            }
        }

        private void ClosePokedex_Click(
            object sender, RoutedEventArgs e)
        {
            PokedexOverlay.Visibility = Visibility.Collapsed;
        }

        private void PokedexList_SelectionChanged(
            object sender, SelectionChangedEventArgs e)
        {
            if (PokedexList.SelectedItem is PokemonInventoryItem pokemon)
            {
                SelectedPokemonImage.Source =
                    new BitmapImage(new Uri(
                        pokemon.ImagePath, UriKind.Absolute));

                SelectedPokemonName.Text = pokemon.Name;

                SelectedPokemonRarity.Text =
                    "Rarity: " + pokemon.Rarity;

                SelectedPokemonCount.Text =
                    "Owned: " + pokemon.Count;
            }
            else
            {
                SelectedPokemonImage.Source = null;
                SelectedPokemonName.Text = "Select a Pokémon";
                SelectedPokemonRarity.Text = "";
                SelectedPokemonCount.Text = "";
            }
        }
    }
}
