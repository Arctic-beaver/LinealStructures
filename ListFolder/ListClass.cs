using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_lineal
{
    public class ListClass
    {
        static Node head = new Node();
        static int amount_of_nodes = 0;

        public int chosen_pos, chosen_el;

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

        public string ToStr()
        {
            string list_to_str = "";
            Node shovel = head;
            int counter = 0;
            while (shovel.GetNext() != null)
            {
                shovel = shovel.GetNext();
                list_to_str += shovel.GetData();
                list_to_str += " -> ";
                if (counter % 20 == 0 && counter != 0) list_to_str += "\n";
                counter += 1;
                
            }
            return list_to_str;
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

        public void CreateNode(Node previous, int data, bool is_end)
        {
            //to the end or center
            Node new_node = new Node();
            new_node.SetData(data);
            if (!is_end)
            {
              new_node.SetNext(previous.GetNext());
            }
            
            previous.SetNext(new_node);
        }

        public void CreateNode(int data)
        {
            //to head
            Node new_node = new Node();
            new_node.SetData(data);

            if (amount_of_nodes != 0)
            {
                new_node.SetNext(head.GetNext());
            }
            head.SetNext(new_node);
        }

        public void Add(int data, int position)
        {
            if (position == 0)
            {
                //to the head
                CreateNode(data);
            }
            else if (position == amount_of_nodes)
            {
                //to the end
                CreateNode(GetOnPos(position - 1), data, true);
            }
            else
            {
                CreateNode(GetOnPos(position - 1), data, false);
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
            amount_of_nodes -= 1;
        }

        public void Free()
        {
            head = null;
        }
    }
}
