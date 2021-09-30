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
    public partial class ListChooseElementForm : Form
    {
        ListClass list;
        public ListChooseElementForm(ListClass list_given)
        {
            InitializeComponent();
            list = list_given;
        }

        private void ListChooseElementForm_Load(object sender, EventArgs e)
        {
            
        }

       

        private void NextButton_Click(object sender, EventArgs e)
        {
            int number;
            bool success = int.TryParse(chosenE1.Text, out number);
            if (success)
            {
                list.chosen_el = Convert.ToInt32(chosenE1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong entering!");
            }
            
        }
    }
}
