using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue_DylanAbeyta
{
    class GenericQueue<T> : IEmptyable, iPrintable, ICountable where T : IComparable
    {
        List<T> holder = new List<T>();

        public GenericQueue()
        {

        }

        //Push
        public void EnQueue(T val)
        {
            holder.Insert(0, val);
        }

        //Pop
        public T DeQueue()
        {
            if (holder.Count == 0)
            {
                return default(T);
            }

            T temp = holder[holder.Count - 1];
            holder.RemoveAt(holder.Count - 1);
            return temp;

        }

        //Peek
        public T Peek()
        {
            T temp = holder[holder.Count - 1];
            return temp;
        }

        //Print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.Write(holder[i] + ", ");
            }
            Console.WriteLine();
        }
        //Search
        public int Search(T val)
        {

            for (int i = 0; i < holder.Count; i++)
            {
                if (val.CompareTo(holder[i]) == 0)
                {
                    return i;

                }
            }

            return 0;
        }

        public void Empty()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return holder.Count();
        }

        public void Printer()
        {
            throw new NotImplementedException();
        }       
    }
}
