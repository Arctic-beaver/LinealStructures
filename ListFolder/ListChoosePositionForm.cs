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
    public partial class ListChoosePositionForm : Form
    {
        bool include_first_zero;
        ListClass list;
        public ListChoosePositionForm(ListClass list_given, bool include_first_zero_given)
        {
            InitializeComponent();

            list = list_given;
            include_first_zero = include_first_zero_given;
        }

        private void ListChoosePositionForm_Load(object sender, EventArgs e)
        {
            if (include_first_zero)
            {
                chosenPos.Maximum = list.GetAmountOfNodes();
            }
            else
            {
                chosenPos.Maximum = list.GetAmountOfNodes() - 1;
            }

            chosenPos.Minimum = 0;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            list.chosen_pos = (int)chosenPos.Value;
            this.Close();
        }
    }
}
