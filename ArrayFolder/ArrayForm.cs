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
    public partial class ArrayForm : Form
    {
        ArrayClass array = new ArrayClass();
        public ArrayForm(ArrayClass given_array)
        {
            InitializeComponent();
            array = given_array;
        }

        public void WriteArray()
        {
            string mas_to_str = "";
            for (int i = 0; i < array.Lenght(); i++)
            {
                mas_to_str += array.Get(i) + " ";
                if ((i % 20 == 0) && (i != 0)) mas_to_str += "\n";
            }

            MasLabel.Text = mas_to_str;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArrayForm_Load(object sender, EventArgs e)
        {
            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;

            WriteArray();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form arrayChoosePositionForm = new ArrayChoosePositionForm(array);
            arrayChoosePositionForm.ShowDialog();
            mainArrayLabel.Text = "Write a number (element that you want to add) -> ";
            NextAddButton.Text = "Next";
            pictureBox2.Visible = false;
            mainArrayBox.Enabled = true;
            mainArrayBox.Visible = true;
            NextAddButton.Visible = true;
            NextAddButton.Enabled = true;
        }

        private void NextAddButton_Click(object sender, EventArgs e)
        {
            if (mainArrayBox.Text == "") return;
            array.Add(Convert.ToInt32(mainArrayBox.Text), array.chosen_pos);
            MessageBox.Show("Элемент успешно добавлен!");
            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;
            WriteArray();
        }
    }
}
