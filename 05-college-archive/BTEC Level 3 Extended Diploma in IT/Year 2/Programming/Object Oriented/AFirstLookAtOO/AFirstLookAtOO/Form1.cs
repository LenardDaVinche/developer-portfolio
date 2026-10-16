using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFirstLookAtOO
{
    public partial class Form1 : Form
    {
        Giant g1;
        Giant g2;
        Archer a1;
        Archer a2;
        Random gen;

        public Form1()
        {
            InitializeComponent();

            gen = new Random(DateTime.Now.Millisecond);

            g1 = new Giant();
            g2 = new Giant();

            a1 = new Archer();
            a2 = new Archer();
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
                lblOutcome.Text = "Giant 1 Wins";
            }
            else
            {
                lblOutcome.Text = "Giant 1 Looses :(";
            }
            //Display outcome
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArcherOneAttack_Click(object sender, EventArgs e)
        {
            a1.Level = gen.Next(1, 6);
            a2.Level = gen.Next(1, 6);

            bool result = a1.Attack(a2);

            if (result == true)
            {
                lblOutcome.Text = "Archer 1 Wins :)";
            }
            else
            {
                lblOutcome.Text = "Archer 2 Looses :(";
            }
        }
    }
}
