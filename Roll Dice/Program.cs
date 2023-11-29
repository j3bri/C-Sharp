namespace Roll_Dice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int player;
            int enemy;
            int playerPoints = 0;
            int enemyPoints = 0;
            Random playernum = new();
            Random enemynum = new();
            Console.WriteLine($"Welcome To The Dice Game");
            Console.WriteLine("Enter Any Key To Start: ");
            for (int i = 0; i < 10; i++)
            {
                _ = Console.ReadKey();
                player = playernum.Next(1, 7);
                Console.WriteLine($"YOUR NUMBER IS {player}");
                Console.WriteLine($"...");

                System.Threading.Thread.Sleep(1000);

                enemy = enemynum.Next(1, 7);
                Console.WriteLine($"THE ENEMY NUMBER IS {enemy}\n");

                if (player > enemy)
                {
                    playerPoints++;
                    Console.WriteLine($"YOU WIN THIS ROUND");
                    Console.WriteLine($"YOUR POINTS: {playerPoints} .. ENEMY POINTS: {enemyPoints}");
                }
                else if (enemy > player)
                {
                    enemyPoints++;
                    Console.WriteLine($"THE ENEMY WIN THIS ROUND");
                    Console.WriteLine($"YOUR POINTS: {playerPoints} .. ENEMY POINTS: {enemyPoints}");
                }
                else
                {
                    Console.WriteLine($"IT'S DRAW!");
                    Console.WriteLine($"YOUR POINTS: {playerPoints} .. ENEMY POINTS: {enemyPoints}");
                }
                Console.WriteLine("ENTER AGAIN: ");
            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine($"YOU WIN :)");
            }
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine($"YOU LOSE :(");
            }
            else
            {
                Console.WriteLine($"IT'S DRAW!");
            }

            _ = Console.ReadKey();
        }
    }
}