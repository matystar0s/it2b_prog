namespace CichnamonArena
{
    static class CichnamonFactory
    {
        public static List<Cichnamon> VytvorStartovni()
        {
            return new List<Cichnamon>
            {
                new Cichnamon(
                    "Ohnivák Oldřich", 100, 5,
                    new Utok("Ohníček",    10, "Oldřich plivl malý plamínek."),
                    new Utok("Plamenomet", 22, "Sežehující proud ohně popálí vše v cestě!")
                ),
                new Cichnamon(
                    "Vodouch Vojtěch", 110, 3,
                    new Utok("Cáknutí",    9,  "Vojtěch cákl studenou vodou."),
                    new Utok("Vodní dělo", 20, "Mohutný proud vody smete nepřítele!")
                ),
                new Cichnamon(
                    "Travomil Tonda", 120, 2,
                    new Utok("Listí",         8,  "Tonda hodil kopem listí do obličeje."),
                    new Utok("Jedovatý výpar", 19, "Hustý zelený dým otráví protivníka!")
                )
            };
        }

        public static List<Cichnamon> VytvorProtivniky()
        {
            return new List<Cichnamon>
            {
                new Cichnamon(
                    "Zlomysl", 95, 4,
                    new Utok("Škrábnutí",  10, "Zlomysl zaútočil ostrými drápy."),
                    new Utok("Temná vlna", 20, "Záhadná temná energie zasáhne nepřítele!")
                ),
                new Cichnamon(
                    "Bleskoještěr", 100, 6,
                    new Utok("Jiskra",     11, "Malá jiskra vyskočí na protivníka."),
                    new Utok("Blesk",      21, "Mocný blesk z nebe uhodí do nepřítele!")
                ),
                new Cichnamon(
                    "Kameňák", 130, 1,
                    new Utok("Odhoz kamene", 9,  "Kameňák hodí oblázek."),
                    new Utok("Lavina",       23, "Obrovská lavina kamenů pohřbí protivníka!")
                )
            };
        }
    }
}
