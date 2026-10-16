using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String input = string.Empty;
        String operand1 = string.Empty;
        String operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            input += "0";
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            input += "1";
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            input += "2";
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            input += "3";
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            input += "4";
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            input += "5";
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            input += "6";
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            input += "7";
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            input += "8";
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            input += "9";
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {

        }
    }
}
