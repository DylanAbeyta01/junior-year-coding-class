using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_DylanAbeyta
{
    class Stack
    {
        List<int> holder = new List<int>();

        public Stack()
        {
            
        }

        //Push
        public void Push(int val)
        {
            holder.Add(val);
        }

        //Pop
        public int Pop()
        {
            if (holder[0] == null)
            {
                Console.WriteLine("there are no numbers in the list. Press 1 and push a value.");
            }
                    
            int temp = holder[holder.Count - 1];
            holder.RemoveAt(holder.Count - 1);            
            return temp;
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
