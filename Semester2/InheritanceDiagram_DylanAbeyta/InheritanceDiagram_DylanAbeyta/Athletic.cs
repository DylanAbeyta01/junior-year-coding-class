using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    abstract class Athletic : Shoes
    {
        protected bool goodGrip;
        protected bool breathable;

        public Athletic(string brand, string color, string material, int size, bool goodGrip, bool breathable)
            : base(brand, color, material, size)
        {
            this.goodGrip = goodGrip;
            this.breathable = breathable;
        }

        public override abstract void PrintShoes();
            
    }
}
