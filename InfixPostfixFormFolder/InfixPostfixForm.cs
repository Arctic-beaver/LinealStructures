using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_lineal
{
    public partial class InfixPostfixForm : Form
    {
        StackClass stack = new StackClass();
        string infix;
        public InfixPostfixForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void EnterInfixBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToPostfixButton_Click(object sender, EventArgs e)
        {
            infix = EnterInfixBox.Text;
            bool previous_is_number = false;
            string output = "";
            for (int i = 0; i < infix.Length; i++)
            {
                if (infix.Substring(i, 1) != " ")
                {
                    if (!previous_is_number)
                    {
                        output += " ";
                    }

                    int number;
                    bool success = int.TryParse(infix.Substring(i, 1), out number);
                    if (success)
                    {
                        //это число
                        output += infix.Substring(i, 1);
                        previous_is_number = true;
                    }
                    else if (infix.Substring(i, 1) == "*" || infix.Substring(i, 1) == "/")
                    {
                        //знак операции
                        //выталкивание элементов из стека до операции с меньшим приоритетом
                        //до «+», «—» или «(»
                        //или до опустошения стека и запись их в постфиксную строку;
                        //в противном случае стек не изменяется. Затем вталкивание операции в стек.
                        while (stack.AmountOfEl() != 0 && stack.Peek() != "+" && stack.Peek() != "-" && stack.Peek() != "(")
                        {
                            output += " " + stack.Pop();
                        }
                        stack.Push(infix.Substring(i, 1));
                        previous_is_number = false;
                    }
                    else if (infix.Substring(i, 1) == "-" || infix.Substring(i, 1) == "+")
                    {
                        //знак операции
                        //выталкивание элементов из стека до операции с меньшим приоритетом
                        //до «(»
                        //или до опустошения стека и запись их в постфиксную строку;
                        //в противном случае стек не изменяется. Затем вталкивание операции в стек.
                        while (stack.AmountOfEl() != 0 && stack.Peek() != "(")
                        {
                            output += " " + stack.Pop();
                        }
                        stack.Push(infix.Substring(i, 1));
                        previous_is_number = false;

                    }
                    else if (infix.Substring(i, 1) == "(")
                    {
                        //открывающая скобка
                        stack.Push(infix.Substring(i, 1));
                        previous_is_number = false;
                    }
                    else if (infix.Substring(i, 1) == ")")
                    {
                        //закрывающщая скобка
                        //Выталкивание элементов из стека до первой открывающей скобки
                        //и запись их в постфиксную строку, затем выталкивание самой открывающей
                        //скобки без записи ее в постфиксную строку. Если перед выполнением этой операции стек
                        //оказался пустым, значит, для данной закрывающей скобки не было парной открывающей,
                        //т.е. возникла исключительная ситуация.

                        if (stack.AmountOfEl() == 0)
                        {
                            MessageBox.Show("Нет открывающей скобки, но есть закрывающая.");
                            return;
                        }
                        while (stack.Peek() != "(" && stack.AmountOfEl() != 0)
                        {
                            output += " " + stack.Pop();
                        }
                        if (stack.AmountOfEl() == 0)
                        {
                            MessageBox.Show("Нет открывающей скобки, но есть закрывающая.");
                            return;
                        }
                        else stack.Pop(); //убрали ( из стека
                        previous_is_number = false;
                    }
                }
            }
            while (stack.AmountOfEl() != 0)
            {
                output += " " + stack.Pop();
            }
            PostfixLabel.Text = output;
        }
    }
}
