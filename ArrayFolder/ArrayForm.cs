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
            for (int i = 0; i < array.Length(); i++)
            {
                mas_to_str += array.Get(i) + " ";
                if ((i % 20 == 0) && (i != 0)) mas_to_str += "\n";
            }

            MasLabel.Text = mas_to_str;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Dispose();
            array.Dispose();
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
            Form arrayChoosePositionForm = new ArrayChoosePositionForm(array, true);
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
            int number;
            bool success = int.TryParse(mainArrayBox.Text, out number);
            if (success)
            {
                array.Add(Convert.ToInt32(mainArrayBox.Text), array.chosen_pos);
            MessageBox.Show("Element added successfully!");
            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;
            WriteArray();
            }
            else
            {
                MessageBox.Show("Wrong entering!");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (array.FilledLength() == 0)
            {
                MessageBox.Show("Чтобы продать что-нибудь ненужное, нужно купить что-нибудь ненужное... Короче нечего удалять.");
            }
            Form arrayChoosePositionForm = new ArrayChoosePositionForm(array, false);
            arrayChoosePositionForm.ShowDialog();

            array.Delete(array.chosen_pos);
            MessageBox.Show("Element deleted successfully!");

            WriteArray();
        }

        private void GetElementButton_Click(object sender, EventArgs e)
        {
            Form arrayChoosePositionForm = new ArrayChoosePositionForm(array, false);
            arrayChoosePositionForm.ShowDialog();
            MessageBox.Show("Element on this position: " + Convert.ToString(array.Get(array.chosen_pos)));
        }

        private void FindPositionButton_Click(object sender, EventArgs e)
        {
            Form arrayChosenElementForm = new ArrayChooseElementForm(array);
            arrayChosenElementForm.ShowDialog();
            int result = array.Find(array.chosen_el);
            if (result == -1)
            {
                MessageBox.Show("We don't have such an element in our array!");
            }
            else MessageBox.Show("Position: " + Convert.ToString(result));
        }

        private void LenghtBurron_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Length: " + Convert.ToString(array.Length()));
        }

        private void FilledLenghtButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount of elements: " + Convert.ToString(array.FilledLength()));
        }
    }
}
