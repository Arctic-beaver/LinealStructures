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
        public ArrayChoosePositionForm(ArrayClass givenArray)
        {
            InitializeComponent();
            array = givenArray;
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
            chosenPos.Maximum = array.FilledLength();
            chosenPos.Minimum = 0;
        }
    }
}
