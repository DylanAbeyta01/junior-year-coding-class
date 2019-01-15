using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    class Boots : Casual
    {
        protected bool thick;

        public Boots(bool thick, string brand, string color, string material, int size, bool slipOn)
            : base(brand, color, material, size, slipOn)
        {
            this.thick = thick;
        }

        public override void PrintShoes()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The boots are thick: " + thick);
            Console.WriteLine("         Thick boots are good because boot are usually used for hiking and outdoors activities and thick shoes are good to protect your feet.");
            Console.WriteLine("What is your brand: " + brand);
            Console.WriteLine("         A brand makes certain types of shoes and has different qualities.");
            Console.WriteLine("What color is your shoe: " + color);
            Console.WriteLine("         The color of a shoe is best when it matches the clothes you are wearing.");
            Console.WriteLine("What material: " + material);
            Console.WriteLine("         different materials are good for different styles.");
            Console.WriteLine("What size: " + size);
            Console.WriteLine("         size is important because if you get the wrong size then the shoe won't fit.");
            Console.WriteLine("Shoes are slip ons: " + slipOn);
            Console.WriteLine("         Slip on shoes are more convenient when putting your shoes on.");

        }
    }
}
