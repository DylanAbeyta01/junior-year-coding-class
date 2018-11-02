using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_WaterGun
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterGun player1 = new WaterGun();
            WaterGun player2 = new WaterGun();
            float cap = 1; 

            int amount = 0;
            int opt = 0;

            Console.WriteLine("Welcome to watergun duel");

            do
            {
                Console.WriteLine("1) shoot");
                Console.WriteLine("2) refill");
                opt = int.Parse(Console.ReadLine());         
                
                if (opt == 1)
                {
                    Console.WriteLine("What percent of your tank would you like to fire?");
                    amount  = int.Parse(Console.ReadLine());
                    cap -= amount;
                    float percentChance = (amount * .2f) + .2f;
                }
                if (opt == 2)
                {
                    cap += .25f;
                }
            } while ();
            
        }        
    }
}
