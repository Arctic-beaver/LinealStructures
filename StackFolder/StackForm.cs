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
    public partial class StackForm : Form
    {
        StackClass stack = new StackClass();
        public StackForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            stack.Finish();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainArrayLabel.Text = "Write element that you want to add -> ";
            NextAddButton.Text = "Next";
            pictureBox2.Visible = false;
            mainArrayBox.Enabled = true;
            mainArrayBox.Visible = true;
            NextAddButton.Visible = true;
            NextAddButton.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void NextAddButton_Click(object sender, EventArgs e)
        {
            if (mainArrayBox.Text == "") return;

            stack.Push(Convert.ToInt32(mainArrayBox.Text));
            MessageBox.Show("Element added successfully!");
            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;
            WriteList();
        }

        private void mainArrayLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainArrayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YourListLabel_Click(object sender, EventArgs e)
        {

        }

        private void ListLabel_Click(object sender, EventArgs e)
        {

        }

        public void WriteList()
        {
            string List_to_str = stack.list.ToStr();
            ListLabel.Text = List_to_str;
        }

        private void StackForm_Load(object sender, EventArgs e)
        {
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;

            WriteList();
        }

        private void PopButton_Click(object sender, EventArgs e)
        {
            int data = stack.Pop();
            MessageBox.Show($"Your element: {data} and now it is GONEEEEEEEE");
            WriteList();
        }

        private void PeekButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your element: {stack.Peek()}");
        }
    }
}
