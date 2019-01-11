using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiagram_DylanAbeyta
{
    class Basketball : Athletic
    {
        protected bool ankleSupport;

        public Basketball (bool ankleSupport)
        {
            this.ankleSupport = ankleSupport; 
        }

    }
}
