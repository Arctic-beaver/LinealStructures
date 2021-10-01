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
    public partial class ListForm : Form
    {
        ListClass list = new ListClass();
        public ListForm()
        {
            InitializeComponent();
        }

        public void WriteList()
        {
            string List_to_str = list.ToString();
            ListLabel.Text = List_to_str;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Dispose();
            list.Dispose();
            this.Close();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            list.Add("0", 0);
            list.Add("1", 1);
            list.Add("мяф", 2);
            list.Add("3", 3);
            list.Add("4", 4);

            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;

            WriteList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           
            Form listChoosePositionForm = new ListChoosePositionForm(list, true);
            listChoosePositionForm.ShowDialog();
            mainArrayLabel.Text = "Write element that you want to add -> ";
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

            list.Add(Convert.ToString(mainArrayBox.Text), list.chosen_pos);
            MessageBox.Show("Element added successfully!");
            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;
            WriteList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (list.GetAmountOfNodes() == 0)
            {
                MessageBox.Show("Чтобы продать что-нибудь ненужное, нужно купить что-нибудь ненужное... Короче нечего удалять.");
            }
            Form listChoosePositionForm = new ListChoosePositionForm(list, false);
            listChoosePositionForm.ShowDialog();

            list.Delete(list.chosen_pos);
            MessageBox.Show("Element deleted successfullly");

            WriteList();
        }

        private void GetElementButton_Click(object sender, EventArgs e)
        {
            Form listChoosePositionForm = new ListChoosePositionForm(list, false);
            listChoosePositionForm.ShowDialog();
            MessageBox.Show("Element on this position: " + Convert.ToString(list.GetDataOnPos(list.chosen_pos)));
        }

        private void FindPositionButton_Click(object sender, EventArgs e)
        {
            Form listChosenElementForm = new ListChooseElementForm(list);
            listChosenElementForm.ShowDialog();
            string result = Convert.ToString(list.Find(list.chosen_el));
            if (result == "-1")
            {
                MessageBox.Show("We don't have such an element in our list!");
            }
            else MessageBox.Show("Position: " + result);
        }

        private void LenghtBurron_Click(object sender, EventArgs e)
        {
        }

        private void FilledLenghtButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of elements: " + Convert.ToString(list.GetAmountOfNodes()));
        }
    }
}
