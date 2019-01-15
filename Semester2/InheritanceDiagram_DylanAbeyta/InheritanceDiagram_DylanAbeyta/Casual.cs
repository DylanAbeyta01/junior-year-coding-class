using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    abstract class Casual : Shoes
    {
        protected bool slipOn;

        public Casual (string brand, string color, string material, int size, bool slipOn)
            : base(brand, color, material, size)
        {
            this.slipOn = slipOn;
        }
      
        public override abstract void PrintShoes();
        
              
    }
}
