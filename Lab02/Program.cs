/*
 * Student ID :16907071477
 * Name       :Tanapat Yurawan
 * Section    :129B
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true; 
            
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine();

            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;

            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // Part B

            // Unit 1 - Archer
            string characterName1 = "Luna";
            char characterRank1 = 'A';
            int characterLevel1 = 12;
            float characterSpeed1 = 15.5f;
            bool characterAlive1 = true;

            Console.WriteLine("===== CHARACTER 1: LUNA =====");
            Console.WriteLine($"Name: {characterName1}");
            Console.WriteLine($"Rank: {characterRank1}");
            Console.WriteLine($"Level: {characterLevel1}");
            Console.WriteLine($"Speed: {characterSpeed1}");
            Console.WriteLine($"Alive: {characterAlive1}");

            // Unit 2 - Knight
            string characterName2 = "Draven";
            char characterRank2 = 'S';
            int characterLevel2 = 20;
            double characterDefense2 = 85.75f;
            bool characterAlive2 = true;

            Console.WriteLine("===== CHARACTER 2: DRAVEN =====");
            Console.WriteLine($"Name: {characterName2}");
            Console.WriteLine($"Rank: {characterRank2}");
            Console.WriteLine($"Level: {characterLevel2}");
            Console.WriteLine($"Defense: {characterDefense2}");
            Console.WriteLine($"Alive: {characterAlive2}");

            // Unit 3 - Mage
            string characterName3 = "Aeris";
            char characterRank3 = 'B';
            int characterMana3 = 450;
            float characterMagicPower3 = 72.5f;
            bool characterAlive3 = true;

            Console.WriteLine("===== CHARACTER 3: AERIS =====");
            Console.WriteLine($"Name: {characterName3}");
            Console.WriteLine($"Rank: {characterRank3}");
            Console.WriteLine($"Mana: {characterMana3}");
            Console.WriteLine($"Magic Power: {characterMagicPower3}");
            Console.WriteLine($"Alive: {characterAlive3}");

            // Unit 4 - Assassin
            string characterName4 = "Shade";
            char characterRank4 = 'S';
            int characterLevel4 = 18;
            double characterCriticalRate4 = 30.25f;
            bool characterInvisible4 = false;

            Console.WriteLine("===== CHARACTER 4: SHADE =====");
            Console.WriteLine($"Name: {characterName4}");
            Console.WriteLine($"Rank: {characterRank4}");
            Console.WriteLine($"Level: {characterLevel4}");
            Console.WriteLine($"Critical Rate: {characterCriticalRate4}");
            Console.WriteLine($"Invisible: {characterInvisible4}");




























        }



































    }
}
