using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_lineal
{
    public class Node
    {
        int data;
        Node next = null;

        public void SetNext(Node next)
        {
            this.next = next;
        }

        public void SetData(int data)
        {
            this.data = data;
        }

        public Node GetNext()
        {
            return this.next;
        }
        public int GetData()
        {
            return this.data;
        }
    }
}
