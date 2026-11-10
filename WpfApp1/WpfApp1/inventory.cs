
using System.ComponentModel;
using clicker;

namespace WpfApp1
{
    public class PokemonInventoryItem : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public PokemonRarity Rarity { get; set; }

        public string ImagePath { get; set; }

        private int count;

        public int Count
        {
            get => count;

            set
            {
                count = value;

                PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        public PokemonInventoryItem(
            string name,
            PokemonRarity rarity,
            int count,
            string imagePath)
        {
            Name = name;
            Rarity = rarity;
            Count = count;
            ImagePath = imagePath;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
