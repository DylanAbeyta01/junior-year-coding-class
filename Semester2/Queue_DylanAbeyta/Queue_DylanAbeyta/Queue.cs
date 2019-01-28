using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_DylanAbeyta
{
    class Queue
    {
        List<int> holder = new List<int>();

        public Queue()
        {

        }

        //Push
        public void EnQueue(int val)
        {            
            holder.Insert(0, val);
        }

        //Pop
        public int DeQueue()
        {
            int temp;
            if (holder.Count == 0)
            {
                temp = -1;
                return temp;
            }
            else if (holder.Count != 0)
            {
                temp = holder[holder.Count - 1];
                holder.RemoveAt(holder.Count - 1);
                return temp;
            }
            return 0;
        }

        //Peek
        public int Peek()
        {
            int temp = holder[holder.Count - 1];
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
        public int Search(int val)
        {

            for (int i = 0; i < holder.Count; i++)
            {
                if (val == holder[i])
                {
                    return ((holder.Count - 1) - i);

                }
            }

            return -1;
        }
    }
}
