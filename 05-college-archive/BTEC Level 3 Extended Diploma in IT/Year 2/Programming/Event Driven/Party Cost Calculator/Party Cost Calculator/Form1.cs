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
        public Form1()
        {
            InitializeComponent();

        }
        public void CalculateCost()
        {
            double Cost = 500;
            double Vat = 0;
            double TotalCost = 0;

            //Band

            if (chkBand.Checked)
            {
                Cost += 600;
            }

            //Under 18

            int Under18 = Convert.ToInt32(nudUnder18.Value);
            Cost = Under18 * 7;

            //Over 18

            int Over18 = Convert.ToInt32(nudOver18.Value);
            Cost = Over18 * 10;

            //Food

            if (chkFood.Checked)
            {

            }

            //VAT
            Vat = Cost * 0.175;
            TotalCost = Cost + Vat;

            //Calculation
            lblCostNumber.Text = "£ " + Cost;
            lblCostVATNumber.Text = "£ " + Vat;
            lblTotalNumber.Text = "£ " + TotalCost;
        
        }
        private void chkBand_CheckChanged(object sender, PaintEventArgs e)
        {
            CalculateCost();
        }
        private void nudUnder18_ValueChanged(object sender, PaintEventArgs e)
        {
            CalculateCost();
        }
        private void nudOver18_ValueChanged(object sender, PaintEventArgs e)
        {
            CalculateCost();
        }
        private void chkFood_CheckChanged(object sender, PaintEventArgs e)
        {
            CalculateCost();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
