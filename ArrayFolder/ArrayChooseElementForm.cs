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
    public partial class ArrayChooseElementForm : Form
    {
        ArrayClass array;
        public ArrayChooseElementForm(ArrayClass givenArray)
        {
            InitializeComponent();
            array = givenArray;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int number;
            bool success = int.TryParse(chosenE1.Text, out number);
            if (success)
            {
                array.chosen_el = Convert.ToInt32(chosenE1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong entering!");
            }
        }

        private void chosenEl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ArrayChooseElementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
