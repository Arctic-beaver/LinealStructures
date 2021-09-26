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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArrayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
