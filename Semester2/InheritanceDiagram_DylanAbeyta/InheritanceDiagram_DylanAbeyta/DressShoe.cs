using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    class DressShoe : Casual
    {
        protected bool stiff;

        public DressShoe(bool stiff, string brand, string color, string material, int size, bool slipOn)
            : base (brand, color, material, size, slipOn)
        {
            this.stiff = stiff;
        }

        public override void PrintShoes()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Shoes are stiff: " + stiff);
            Console.WriteLine("         Dress shoes are usually stiff because of the material they are made from and they can made the shoe look more classy");
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
