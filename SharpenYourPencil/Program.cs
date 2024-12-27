using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenYourPencil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
                        
            while (true)
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
                string line = Console.ReadLine();
                int num;
                if (!int.TryParse(line, out num)) continue;
                Console.WriteLine($"You pressed {num}");

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();
                        break;
                    case 2:
                        Console.WriteLine("Calling lucinda.WhoAmI()");
                        lucinda.WhoAmI();
                        break;
                    case 3:
                        Console.WriteLine("References have been swapped");
                        Elephant temp = lucinda;
                        lucinda = lloyd;
                        lloyd = temp;
                        break;
                    default:
                        break;
                }
                Console.WriteLine();

                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'Q' || keyChar == 'q') break;
            }
        }
    }
}
