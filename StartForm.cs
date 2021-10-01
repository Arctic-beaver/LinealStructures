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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void List_Click(object sender, EventArgs e)
        {
            using (Form listForm = new ListForm())
            {
               listForm.ShowDialog();
            };
        }

        private void Array_Click(object sender, EventArgs e)
        {
            using (Form arrayInitForm = new ArrayInitForm())
            {
                arrayInitForm.ShowDialog();
            };
        }

        private void Stack_Click(object sender, EventArgs e)
        {using (Form stackForm = new StackForm())
            {
                stackForm.ShowDialog();
            };
         }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfixPostfixButton_Click(object sender, EventArgs e)
        {
            using (Form infixPostfixForm = new InfixPostfixForm())
            {
                infixPostfixForm.ShowDialog();
            };
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
