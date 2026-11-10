
namespace clicker
{
    public enum PokemonRarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Mythic,
        Secret
    }

    public class Pokemon
    {
        public string Name { get; set; }

        public PokemonRarity Rarity { get; set; }

        public int ClickAdd { get; set; }

        public string ImagePath { get; set; }

        public Pokemon(
            string name,
            PokemonRarity rarity,
            int clickAdd,
            string imagePath)
        {
            Name = name;
            Rarity = rarity;
            ClickAdd = clickAdd;
            ImagePath = imagePath;
        }
    }
}
