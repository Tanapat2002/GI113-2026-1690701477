namespace Lab_6
/*
* Student ID : 1690701477
* Name       : Tanapat Yurawan
* Section    : 129B
* No.        :20
* Course     : GI113 Computer Programming (GI)
*/


{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game name Assassin Cat VS Baby Boss
            int catHp = 100;
            int bossHp = 100;
            int clawDamage = 25;
            int biteDamage = 40;
            int babyDamage = 15;
            int milkHeal = 30;

            Console.WriteLine("====================================");
            Console.WriteLine("      ASSASSIN CAT VS BABY BOSS");
            Console.WriteLine("====================================");
            Console.WriteLine($"Cat HP   : {catHp}");
            Console.WriteLine($"Boss HP  : {bossHp}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ACTION 1 : Attack Boss with Claws");
            Console.WriteLine("ACTION 2 : Attack Boss with Bite");
            Console.WriteLine("ACTION 3 : Attack Boss with Meow");
            Console.WriteLine("ACTION 4 : Drink Milk and Heal");
            Console.WriteLine("------------------------------------");
            Console.Write("Choose your action (1-4): ");

            bool inputValid = int.TryParse(Console.ReadLine(), out int action);

            Console.WriteLine();

            if (!inputValid || action < 1 || action > 4)
            {
                Console.WriteLine("Invalid action. Please choose 1-4.");
            }
            else if (action == 1)
            {
                bossHp -= clawDamage;

                Console.WriteLine("The Assassin Cat attacks the Baby Boss with Claws!");
                Console.WriteLine($"Baby Boss HP : {bossHp}");
            }
            else if (action == 2)
            {
                bossHp -= biteDamage;

                Console.WriteLine("The Assassin Cat attacks the Baby Boss with a Bite!");
                Console.WriteLine($"Baby Boss HP : {bossHp}");
            }
            else if (action == 3)
            {
                catHp -= babyDamage;

                Console.WriteLine("The Assassin Cat uses a powerful Meow!");
                Console.WriteLine("The Baby Boss fights back!");
                Console.WriteLine($"Cat HP : {catHp}");
            }
            else
            {
                catHp += milkHeal;

                Console.WriteLine("The Assassin Cat drinks Milk and recovers health!");
                Console.WriteLine($"Cat HP : {catHp}");
            }

            Console.WriteLine("====================================");
            Console.WriteLine("             TURN END");
            Console.WriteLine("====================================");
        }
    }
}