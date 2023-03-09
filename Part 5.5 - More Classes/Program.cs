namespace Part_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to roll the dice");
            Console.ReadLine();
            die die1 = new die();
            die1.RollDie();
            die1.DrawRoll();
        }
    }
}