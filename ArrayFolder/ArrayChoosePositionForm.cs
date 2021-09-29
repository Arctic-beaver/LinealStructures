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
    public partial class ArrayChoosePositionForm : Form
    {
        ArrayClass array;
        bool include_first_zero;
        public ArrayChoosePositionForm(ArrayClass givenArray, bool include_first_zero_given)
        {
            InitializeComponent();
            array = givenArray;
            include_first_zero = include_first_zero_given;
        }

        private void array_size_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            array.chosen_pos = (int)chosenPos.Value;
            this.Close();
        }

        private void ArrayChoosePositionForm_Load(object sender, EventArgs e)
        {
            if (include_first_zero)
            {
                chosenPos.Maximum = array.FilledLength();
            }
            else
            {
                chosenPos.Maximum = array.FilledLength() - 1;
            }
            
            chosenPos.Minimum = 0;
        }
    }
}
