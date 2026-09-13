
            
            /*
 * Student ID : 1690701477
 * Name       : Tanapat Yurawan
 * Section    : 129B
 * No.        : 
 */

            

namespace Assignment01
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                const string GameTitle = "Pokemon Scarlet";

                var pokemonName = "Koraidon";
                var pokemonRank = 'S';

                int pokemonLevel = 78;
                float attackPower = 245.5f;
                double healthPoint = 389.6;
                bool isLegendary = true;

                Console.WriteLine("========================================");
                Console.WriteLine($"         {GameTitle}");
                Console.WriteLine("         CHARACTER STAT CARD");
                Console.WriteLine("========================================");
                Console.WriteLine($" Pokemon   : {pokemonName}");
                Console.WriteLine($" Rank      : {pokemonRank}");
                Console.WriteLine($" Level     : {pokemonLevel}");
                Console.WriteLine($" Attack    : {attackPower}");
                Console.WriteLine($" HP        : {healthPoint}");
                Console.WriteLine($" Legendary : {isLegendary}");
                Console.WriteLine("----------------------------------------");

                double levelAsDouble = pokemonLevel;
                Console.WriteLine($" Level as Double : {levelAsDouble}");

                Console.WriteLine("----------------------------------------");

                int healthCast = (int)healthPoint;
                int healthConvert = Convert.ToInt32(healthPoint);

                Console.WriteLine($" HP Cast    : {healthCast}");
                Console.WriteLine($" HP Convert : {healthConvert}");

                Console.WriteLine("========================================");
            }
        }
    }

    

