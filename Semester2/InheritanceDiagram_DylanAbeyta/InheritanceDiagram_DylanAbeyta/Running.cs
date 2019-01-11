using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    class Running : Athletic
    {
        protected bool hasSpikes;

        public Running (bool hasSpikes)
            :base(goodGrip, breathable)
        {
            this.hasSpikes = hasSpikes;
        }
    }
}
