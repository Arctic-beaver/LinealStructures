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
    public partial class ArrayInitForm : Form
    {
        public ArrayInitForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ArrayClass array = new ArrayClass();
            array.CreateArray((int)array_size.Value);
            Form arrayForm = new ArrayForm(array);
            arrayForm.ShowDialog();
            this.Close();
        }
    }
}
