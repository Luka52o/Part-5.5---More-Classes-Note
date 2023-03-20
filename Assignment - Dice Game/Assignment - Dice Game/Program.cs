using System.Runtime.CompilerServices;
using System.Transactions;

namespace Assignment___Dice_Game
{
    internal class Program
    {
        public static double balance = 100.00;

        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to play the dice game");
            Console.ReadLine();
            Play();
        }
        public static void Play()
        {
            bool played = false;
            string betType;

            Console.WriteLine($"Welcome to the dice game. Your current balance is ${balance}, please chose a bet from the following list:");
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
                PlayDoubles();
            }
            else if (betType.ToUpper() == "NOT DOUBLES")
            {
                PlayNotDoubles();
            }
            else if (betType.ToUpper() == "EVEN SUM")
            {
                PlayEvenSum();
            }
            else if (betType.ToUpper() == "ODD SUM")
            {
                PlayOddSum();
            }
        }
        public static void PlayDoubles()
        {
            bool usableValueGiven = false;
            double betValue = 0;
            string playAgain;
            
            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            if (die1.Roll == die2.Roll)
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue * 2}");
                balance = balance + (betValue * 2);
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }
                
            }
            else
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - (betValue);
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
        }
        public static void PlayNotDoubles()
        {
            bool usableValueGiven = false;
            double betValue = 0;
            string playAgain;

            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            if (die1.Roll != die2.Roll)
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue / 2}");
                balance = balance + (betValue / 2);
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - (betValue);
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
        }
        public static void PlayEvenSum()
        {
            bool usableValueGiven = false;
            double betValue = 0, rollSum;
            string playAgain;

            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            rollSum = die1.Roll + die2.Roll;
            if (rollSum % 2 == 0)
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue}");
                balance = balance + betValue;
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - betValue;
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
        }
        public static void PlayOddSum()
        {
            bool usableValueGiven = false;
            double betValue = 0, rollSum;
            string playAgain;

            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            rollSum = die1.Roll + die2.Roll;
            if (rollSum % 2 == 0)
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - betValue;
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
            else
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue}");
                balance = balance + betValue;
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        Play();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }
            }
        }
    }
}