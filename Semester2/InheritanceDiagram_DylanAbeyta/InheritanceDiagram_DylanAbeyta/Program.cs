using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to see the shoes");

            List<Shoes> shoe = new List<Shoes>();
            shoe.Add(new Basketball(true, "jordans", "red", "lether", 12, true, true));
            shoe.Add(new Running(true, "asics", "blue", "polyurethane", 10, true, true));
            shoe.Add(new DressShoe(true, "ModClothe", "black", "rubber", 11, false));
            shoe.Add(new Boots(true, "tecovas", "brown", "leather", 9, false));
            for (int i = 0; i < shoe.Count; i++)
            {
                shoe[i].PrintShoes();
            }
            Console.ReadKey();
        }
    }
}
