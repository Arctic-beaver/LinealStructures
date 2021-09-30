using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_lineal
{
    public class Node
    {
        string data;
        Node next = null;

        public void SetNext(Node next)
        {
            this.next = next;
        }

        public void SetData(string data)
        {
            this.data = data;
        }

        public Node GetNext()
        {
            return this.next;
        }
        public string GetData()
        {
            return this.data;
        }
    }
}
