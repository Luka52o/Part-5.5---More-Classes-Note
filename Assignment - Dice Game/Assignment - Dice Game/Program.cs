using System.Transactions;

namespace Assignment___Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool usableValueGiven = false;
            string betType;
            double balance = 100.00;
            double betValue;

            Console.WriteLine($"Welcome to the dice game. Your current balance is {balance}, please chose a bet from the following list:");
            Console.WriteLine("DOUBLES - Roll two dice, earn double your bet if the rolls are the same");
            Console.WriteLine("NOT DOUBLES - Roll two dice, earn half your bet if the rolls do not match");
            Console.WriteLine("EVEN SUM - Roll two dice, earn your bet if the sum of the rolls is an even number");
            Console.WriteLine("ODD SUM - Roll two dice, earn your bet if the sum of the rolls is an odd number");
            Console.WriteLine("Type in your choice into the console:");
            betType = Console.ReadLine();
            while (betType.ToUpper() != "DOUBLES" && betType.ToUpper() != "NOT DOUBLES" && betType.ToUpper() != "EVEN SUM" && betType.ToUpper() != "ODD SUM")
            {
                Console.WriteLine("Please enter a valid bet type:");
                betType = Console.ReadLine();
            }
            if (betType.ToUpper() == "DOUBLES")
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");
                while (!usableValueGiven)
                {
                    if (!double.TryParse(Console.ReadLine(), out betValue))
                        Console.WriteLine("Please enter a valid number value for your bet:");

                    else if (betValue > balance)
                        Console.WriteLine("Please enter a bet smaller than your balance");
                }
                // betValue variable will not be usable outside of these if statements
                die die1 = new die();
                die die2 = new die();
                die1.RollDie6();
                die2.RollDie6();

                die1.DrawRoll();
                Console.WriteLine();
                Console.WriteLine();
                die2.DrawRoll();

                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine($"WINNER! PAYOUT: {betValue * 2}");
                    balance = balance + (betValue * 2);
                }
                else
                {
                    Console.WriteLine($"LOSER. YOU LOST {betValue}");
                    balance = balance - (betValue);
                    Console.WriteLine($"Your account balance is now {balance}.")
                }
            }
            else if (betType.ToUpper() == "NOT DOUBLES")
            {

            }
            else if (betType.ToUpper() == "EVEN SUM")
            {

            }
            else if (betType.ToUpper() == "ODD SUM")
            {

            }
        }
    }
}