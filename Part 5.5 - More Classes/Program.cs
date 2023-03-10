namespace Part_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int load;
            string initialInput;
            int parsedInput;
            die die1 = new die();
            die die2 = new die();
            die die3 = new die();
            die die4 = new die();
            die die5 = new die();
            die die6 = new die();
            die die7 = new die();
            die die8 = new die();
            die die9 = new die();

            Console.WriteLine("Enter a number from 2-9 to specify dice side number, or enter nothing for a standard D6");
            initialInput = Console.ReadLine();
            if (Int32.TryParse(initialInput, out parsedInput) && parsedInput > 1 && parsedInput <= 9)
            {
                if (parsedInput == 2)
                {
                    Console.WriteLine("D2: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 2)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie2();
                        die2.RollDie2();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie2();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie2();
                        die1.DrawRoll();
                    }
                }
                else if (parsedInput == 3)
                {
                    Console.WriteLine("D3: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 3)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie3();
                        die2.RollDie3();
                        die3.RollDie3();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else if (die3.Roll == load)
                        {
                            die3.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie3();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie3();
                        die1.DrawRoll();
                    }
                }
                else if (parsedInput == 4)
                {
                    Console.WriteLine("D4: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 4)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie4();
                        die2.RollDie4();
                        die3.RollDie4();
                        die4.RollDie4();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else if (die3.Roll == load)
                        {
                            die3.DrawRoll();
                        }
                        else if (die4.Roll == load)
                        {
                            die4.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie4();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie4();
                        die1.DrawRoll();
                    }
                }
                else if (parsedInput == 5)
                {
                    Console.WriteLine("D5: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 5)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie5();
                        die2.RollDie5();
                        die3.RollDie5();
                        die4.RollDie5();
                        die5.RollDie5();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else if (die3.Roll == load)
                        {
                            die3.DrawRoll();
                        }
                        else if (die4.Roll == load)
                        {
                            die4.DrawRoll();
                        }
                        else if (die5.Roll == load)
                        {
                            die5.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie5();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie5();
                        die1.DrawRoll();
                    }
                }
                else if (parsedInput == 6)
                {
                    Console.WriteLine("D6: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 6)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie6();
                        die2.RollDie6();
                        die3.RollDie6();
                        die4.RollDie6();
                        die5.RollDie6();
                        die6.RollDie6();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else if (die3.Roll == load)
                        {
                            die3.DrawRoll();
                        }
                        else if (die4.Roll == load)
                        {
                            die4.DrawRoll();
                        }
                        else if (die5.Roll == load)
                        {
                            die5.DrawRoll();
                        }
                        else if (die6.Roll == load)
                        {
                            die6.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie6();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie6();
                        die1.DrawRoll();
                    }
                }
                else if (parsedInput == 7)
                {
                    Console.WriteLine("D7: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 7)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie7();
                        die2.RollDie7();
                        die3.RollDie7();
                        die4.RollDie7();
                        die5.RollDie7();
                        die6.RollDie7();
                        die7.RollDie7();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else if (die3.Roll == load)
                        {
                            die3.DrawRoll();
                        }
                        else if (die4.Roll == load)
                        {
                            die4.DrawRoll();
                        }
                        else if (die5.Roll == load)
                        {
                            die5.DrawRoll();
                        }
                        else if (die6.Roll == load)
                        {
                            die6.DrawRoll();
                        }
                        else if (die7.Roll == load)
                        {
                            die7.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie7();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie7();
                        die1.DrawRoll();
                    }
                }
                else if (parsedInput == 8)
                {
                    Console.WriteLine("D8: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 8)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie8();
                        die2.RollDie8();
                        die3.RollDie8();
                        die4.RollDie8();
                        die5.RollDie8();
                        die6.RollDie8();
                        die7.RollDie8();
                        die8.RollDie8();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else if (die3.Roll == load)
                        {
                            die3.DrawRoll();
                        }
                        else if (die4.Roll == load)
                        {
                            die4.DrawRoll();
                        }
                        else if (die5.Roll == load)
                        {
                            die5.DrawRoll();
                        }
                        else if (die6.Roll == load)
                        {
                            die6.DrawRoll();
                        }
                        else if (die7.Roll == load)
                        {
                            die7.DrawRoll();
                        }
                        else if (die8.Roll == load)
                        {
                            die8.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie8();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie8();
                        die1.DrawRoll();
                    }
                }
                else if (parsedInput == 9)
                {
                    Console.WriteLine("D9: Press ENTER to roll the dice");
                    if (Console.ReadLine().ToUpper() == "LOAD")
                    {
                        Console.WriteLine("Load activated. Enter desired value:");
                        while (!Int32.TryParse(Console.ReadLine(), out load) || load < 0 || load > 9)
                            Console.WriteLine("To load the dice, you need to enter a valid digit from 1-6");
                        die1.RollDie9();
                        die2.RollDie9();
                        die3.RollDie9();
                        die4.RollDie9();
                        die5.RollDie9();
                        die6.RollDie9();
                        die7.RollDie9();
                        die8.RollDie9();
                        die9.RollDie9();
                        if (die1.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else if (die2.Roll == load)
                        {
                            die2.DrawRoll();
                        }
                        else if (die3.Roll == load)
                        {
                            die3.DrawRoll();
                        }
                        else if (die4.Roll == load)
                        {
                            die4.DrawRoll();
                        }
                        else if (die5.Roll == load)
                        {
                            die5.DrawRoll();
                        }
                        else if (die6.Roll == load)
                        {
                            die6.DrawRoll();
                        }
                        else if (die7.Roll == load)
                        {
                            die7.DrawRoll();
                        }
                        else if (die8.Roll == load)
                        {
                            die8.DrawRoll();
                        }
                        else if (die9.Roll == load)
                        {
                            die1.DrawRoll();
                        }
                        else
                        {
                            die1.RollDie9();
                            die1.DrawRoll();
                        }
                    }
                    else
                    {
                        die1.RollDie9();
                        die1.DrawRoll();
                    }
                }
               
            }
            else
            {
                die1.RollDie6();
                die1.DrawRoll();
            }
        }
    }
}