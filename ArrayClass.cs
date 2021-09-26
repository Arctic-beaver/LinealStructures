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
            //mas соберёт сборщик мусора, тк нет ссылок
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
            //-1 
            return;
        }

        public int Find(int element)
        {
            return;
        }

        public int[] Delete()
        {
            return;
        } 

        public void Free()
        {

        }
    }
}
