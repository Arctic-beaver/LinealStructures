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

        ~ListForm()
        {
            list.Free();
        }
        public void WriteList()
        {
            string List_to_str = list.ToStr();
            ListLabel.Text = List_to_str;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
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
            list.Add(Convert.ToInt32(mainArrayBox.Text), list.chosen_pos);
            MessageBox.Show("Элемент успешно добавлен!");
            NextAddButton.Visible = false;
            NextAddButton.Enabled = false;
            mainArrayBox.Enabled = false;
            mainArrayBox.Visible = false;
            pictureBox2.Visible = true;
            WriteList();
        }
    }
}
