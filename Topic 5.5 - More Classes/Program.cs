using System.Reflection.Metadata.Ecma335;

namespace Topic_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();

            int die1Int, die2Int;

            Console.WriteLine("It's time to roll some dice! Press ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Rolling...");
            Thread.Sleep(500);

            Console.WriteLine();

            Console.WriteLine($"Dice 1 rolled a {die1}!");
            die1.DrawRoll();
            Console.WriteLine($"Dice 2 rolled a {die2}!");
            die2.DrawRoll();

            die1Int = Convert.ToInt32(die1.ToString());
            die2Int = Convert.ToInt32(die2.ToString());

            Console.WriteLine();

            if (die1Int == 1 && die2Int == 1)
            {
                Console.WriteLine("You got snake eyes!");
            }
            if (die1Int == die2Int)
            {
                Console.WriteLine("You rolled doubles!");
            }
            if ((die1Int + die2Int) == 7)
            {
                Console.WriteLine("The sum of the two dice is 7!");
            }
            if (((die1Int + die2Int)%2) == 0)
            {
                Console.WriteLine($"The two dice add up to an even sum! The sum of those two dice is {(die1Int + die2Int)}");
            }
            if ((die1Int == 1 && die2Int == 2) || (die1Int == 2 && die2Int == 3) || (die1Int == 3 && die2Int == 4) || (die1Int == 4 && die2Int == 5) || (die1Int == 5 && die2Int == 6) || (die2Int == 1 && die1Int == 2) || (die2Int == 2 && die1Int == 3) || (die2Int == 3 && die1Int == 4) || (die2Int == 4 && die1Int == 5) || (die2Int == 5 && die1Int == 6))
            {
                Console.WriteLine("The dice are sequential!");
            }
            if (die1Int > die2Int)
            {
                Console.WriteLine("Dice 1 is bigger than dice 2!");
            }
            else if (die2Int > die1Int)
            {
                Console.WriteLine("Dice 2 is bigger than dice 1!");
            }
            else
            {
                Console.WriteLine("Dice 1 and dice 2 are the same!");
            }
        }
    }
}
