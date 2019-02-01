using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue_DylanAbeyta
{
    interface IEmptyable
    {
        void Empty();
    }
    interface iPrintable
    {
        void Printer();
    }

    interface ICountable
    {
        int Count();
    }
}
