using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5._5___More_Classes
{
    public class die
    {
        private Random _generator;
        private int _roll;

        public die()
        {
            _generator = new Random();
            _roll = _generator.Next(1,7);
        }

        public die(int roll)
        {

        }
        public int Roll { get { return _roll; } }
        public override string ToString()
        {
            return _roll.ToString();
        }
        
        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("|     |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|     |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 2)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o   |");
                Console.WriteLine("|     |");
                Console.WriteLine("|   o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 3)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o   |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|   o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 4)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o o |");
                Console.WriteLine("|     |");
                Console.WriteLine("| o o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 5)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o o |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("| o o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 6)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o o |");
                Console.WriteLine("| o o |");
                Console.WriteLine("| o o |");
                Console.WriteLine(" ----- ");
            }
        }
    }
}
    
