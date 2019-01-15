using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    abstract class Shoes 
    {
        protected string brand;
        protected string color;
        protected string material;
        protected int size;
        public Shoes (string brand, string color, string material, int size)
        {
            this.brand = brand;
            this.color = color;
            this.material = material;
            this.size = size;
        }

        public abstract void PrintShoes();
                  
       
    }
}
