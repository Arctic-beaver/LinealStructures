using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_lineal
{
    class ArrayClass
    {
        static int length;
        int[] mas;
        int filled_length = 0; 

        public int Lenght()
        {
            return length;
        }

        public int[] CreateArray(int given_length)
        {
            mas = new int[given_length];
            length = given_length;
            return mas;
        }

        public int[] CreateArray()
        {
            mas = new int[5];
            length = 5;
            return mas;
        }

        public void Resize()
        {
            int[] doubled_mas = new int[length * 2];
            
            for (int i = 0; i < length; i++)
            {
                doubled_mas[i] = mas[i];
            }
            length *= 2;
            mas = doubled_mas;
        }

        public void Add(int element, int position)
        {
            if ((position == length-1)||(filled_length == length))
            {
                Resize();
            }

            if (position != filled_length)
            {
                for (int i = filled_length; i > position; i--)
                {
                    mas[i] = mas[i - 1];
                }
            }
           
            mas[position] = element;
            filled_length += 1;
        }

        public void Add(int element)
        {
            Add(element, filled_length);
        }

        public int Get(int position)
        {
            return mas[position];
        }

        public int Find(int element)
        {
            for (int i = 0; i < filled_length; i++)
            {
                //return position
                if (mas[i] == element) return i;
            }
            //if we haven't got such an element
            return -1;
        }

        public void Delete(int position)
        {
            mas[position] = 0;
            if (position != filled_length - 1)
            {
                for (int i = position; i < filled_length - 1; i++)
                {
                    mas[i] = mas[i + 1];
                }
            }
        
        } 

        public void Free()
        {

        }
    }
}
