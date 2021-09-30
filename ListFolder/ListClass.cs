using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_lineal
{
    public class ListClass
    {
        static Node head;
        static int amount_of_nodes = 0;

        public Node GetHead()
        {
            return head;
        }

        public int GetAmountOfNodes()
        {
            return amount_of_nodes;
        }

        public Node GetLast()
        {
            Node shovel = head;
            while (shovel.GetNext() != null)
            {
                shovel = shovel.GetNext();
            }
            return shovel;
        }
        public Node GetOnPos(int position)
        {
            Node shovel = head;
            for (int i = 0; i <= position; i++)
            {
                shovel = shovel.GetNext();
            }
            return shovel;
        }

        public void CreateNode(Node previous, int data)
        {
            //to the end or center
            Node new_node = new Node();
            new_node.SetData(data);
            new_node.SetNext(previous.GetNext());
            previous.SetNext(new_node);
        }

        public void CreateNode(int data)
        {
            //to head
            Node new_node = new Node();
            new_node.SetData(data);

            new_node.SetNext(head.GetNext());
            head.SetNext(new_node);
        }

        public void Add(int data, int position)
        {
            if (position == 0)
            {
                //to the head
                CreateNode(data);
            }
            else
            {
                CreateNode(GetOnPos(position - 1), data);
            }
            amount_of_nodes += 1;
        }

        public void Delete(int position)
        {
            Node shovel = head;
            //find previous;
            for (int i = 0; i < position; i++)
            {
                shovel = shovel.GetNext();
            }
            shovel.SetNext(shovel.GetNext().GetNext());
        }

        public void Free()
        {
            head = null;
        }
    }
}
