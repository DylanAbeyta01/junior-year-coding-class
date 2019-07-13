using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_role
{
    class Program
    {
        static int dice = 0;
        static Random rand = new Random();
        static int input = 0;

        static void Main(string[] args)
        {
            Starter();
        }

        static void Starter()
        {
            Console.WriteLine("****1)  Role a 6 sided dice                       **********");
            Console.WriteLine("****2)  Role a dice with desired number of sides  **********");
            Console.WriteLine("****3)  Quit                                      **********");
            input = int.Parse(Console.ReadLine());

            dice = 0;

            if (input == 1)
            {
                NormalDice();
            }

            if (input == 2)
            {
                UnknownDice();
            }

            if (input == 3)
            {
                Stop();
            }
        }
        static void NormalDice()
        {
            dice = rand.Next(1, 7);

            Console.WriteLine("You have roled the number " + dice);
            Thread.Sleep(5000);
            Console.Clear();
            Starter();
            Console.ReadKey();
        }

        static void UnknownDice()
        {
            Console.WriteLine("how many sides would you like the dice to have?");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("please pick a number greater than 0");
                UnknownDice();
            }

            dice = rand.Next(1, (num + 1));

            Console.WriteLine("You have roled the number " + dice);
            Thread.Sleep(5000);
            Console.Clear();
            Starter();
            Console.ReadKey();
        }
        static void Stop()
        {

        }
    }
}
