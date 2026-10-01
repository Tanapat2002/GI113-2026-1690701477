/*
 * Student ID : 1690701477
 * Name       : Tanapat Yurawan
 * Section    : 129B
 * No.        : 20
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Material settings
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            // Header
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to the Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine($"=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine($"=> Key 'B' for Breakdown (Ingot -> Ore)");

            // Get menu
            Console.Write("=> Choose Menu: ");
            char.TryParse(Console.ReadLine(), out char menu);

            // Get amount
            Console.Write("=> How much would you like: ");
            bool amountParsed = double.TryParse(Console.ReadLine(), out double amount);

             // Validate amount first
             if (amountParsed && amount > 0 && amount <= MaxBatch)
            {
                // Nested if: check menu
                if (menu == 'S' || menu == 's')
                {
                    double ingot = amount * SmeltRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot"
                    );
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double ore = amount / SalvageRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore"
                    );
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu.");
                }
            }
             else
            {
                Console.WriteLine($"Error: Invalid amount. Enter a value greater than 0 and no more than {MaxBatch:F2}.");
            }





        }
    }
}
