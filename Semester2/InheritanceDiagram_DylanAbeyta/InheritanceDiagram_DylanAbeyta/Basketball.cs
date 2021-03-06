﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    class Basketball : Athletic
    {
        protected bool ankleSupport;

        public Basketball (bool ankleSupport, string brand, string color, string material, int size, bool goodGrip, bool breathable)
            :base (brand, color, material, size, goodGrip, breathable)
        {
            this.ankleSupport = ankleSupport; 
        }

        public override void PrintShoes()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You have ankle support: " + ankleSupport);
            Console.WriteLine("         Ankel support is good to remain injury free");
            Console.WriteLine("What is your brand: " + brand);
            Console.WriteLine("         A brand makes certain types of shoes and has different qualities.");
            Console.WriteLine("What color is your shoe: " + color);
            Console.WriteLine("         The color of a shoe is best when it matches the clothes you are wearing.");
            Console.WriteLine("What material: " + material);
            Console.WriteLine("         different materials are good for different styles.");
            Console.WriteLine("What size: " + size);
            Console.WriteLine("         size is important because if you get the wrong size then the shoe won't fit.");
            Console.WriteLine("You have good grip: " + goodGrip);
            Console.WriteLine("         Good grip is good for running so you can stop and run faster.");
            Console.WriteLine("The is shoe breathable: " + breathable);
            Console.WriteLine("         a shoe that is breathable is good for running so you are sweating in your shoes.");
        }
    }
}
