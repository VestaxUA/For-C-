using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_forms_calculator
{
    public partial class Form1 : Form
    {
        private string calcl = "";
        //private bool operClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text.Length != 11)
            {
                calcl += (sender as Button).Text;

                outputBox.Text = calcl;

            }

            /*if ((sender as Button).Text == "+" ||
                    (sender as Button).Text == "-" ||
                    (sender as Button).Text == "*" ||
                    (sender as Button).Text == "/")
            {
                operClicked = true;
            }
            else
            {
                operClicked = false;
            } */

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            outputBox.Text = "0";
            calcl = "";
        }

        private void buttonCancelEntry_Click_1(object sender, EventArgs e)
        {
            if (calcl.Length > 0)
            {
                calcl = calcl.Remove(calcl.Length - 1, 1);
                if (calcl.Length == 0)
                {
                    outputBox.Text = "0";
                } else
                {
                    outputBox.Text = calcl;
                }
            }

            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

                outputBox.Text = new DataTable().Compute(calcl, null).ToString();
                calcl = outputBox.Text;
                //operClicked = false;
        }
    }
}
