using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFirstLookAtOOP
{
    public partial class Form1 : Form
    {
        Giant g1;
        Giant g2;
        Random gen;

        public Form1()
        {
            InitializeComponent();

            gen = new Random(DateTime.Now.Millisecond);

            g1 = new Giant();
            g2 = new Giant();
        }

        private void btnGiantOneAttack_Click(object sender, EventArgs e)
        {
            // Set giant levels randomly

            g1.Level = gen.Next(1, 6);
            g2.Level = gen.Next(1, 6);

            // Call Attack Method
            bool result = g1.Attack(g2);

            if (result == true)
            {
                lblOutcomes.Text = "Giant 1 Wins";
            }
            else
            {
                lblOutcomes.Text = "Giant 1 Looses :(";
            }
            //Display outcome
        }
    }
}
