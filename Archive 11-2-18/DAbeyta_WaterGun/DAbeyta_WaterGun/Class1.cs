using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_WaterGun
{
    class WaterGun
    {
        float cap;
        bool isWet;
        Random rand = new Random();


        public WaterGun()
        {
        }

        public bool Shoot(float amount)
        {
            if (cap > 0)
            {
                cap -= amount;
                float percentChance = (amount * .2f) + .2f;
                if(rand.NextDouble () < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                Console.WriteLine("You do not have water in your gun");
                return false;
            }
        }
        public  void refill()
        {
            cap += .25f;
        }
            
    }
}
