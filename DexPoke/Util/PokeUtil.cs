namespace DexPoke.Util
{
    public class PokeUtil
    {
        public const string Pokeball = "icons8-pokeball-2-48.png";

        public const string GreatBall = "icons8-pokeball-48.png";

        public const string MasterBall = "icons8-mega-ball-48.png";

        public const string Ultraball = "icons8-ultra-ball-48.png";

        public static string GetRandomBall() 
        {
            var pokeballArray = new string[] { Pokeball, GreatBall,Ultraball, MasterBall };

            var rand = new Random();
            string randomBall = pokeballArray[rand.Next(pokeballArray.Length)];

            return randomBall;
        }

        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }

        public static double GetPokemonWeightInKG(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}
