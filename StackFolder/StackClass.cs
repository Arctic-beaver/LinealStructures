using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_lineal
{
    class StackClass
    {
        ListClass list;

        public void Push(int data)
        {
            list.Add(data, list.GetAmountOfNodes());
        }

        public int Pop ()
        {
            int result = list.GetDataOnPos(list.GetAmountOfNodes() - 1);
            list.Delete(list.GetAmountOfNodes() - 1);
            return result;
        }

        public int Peek()
        {
             return list.GetDataOnPos(list.GetAmountOfNodes() - 1);
        }

        public void Finish()
        {
            list.Free();
        }
    }
}
