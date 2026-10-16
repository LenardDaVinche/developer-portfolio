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
    public partial class MyApp2 : Form
    {
        public MyApp2()
        {
            InitializeComponent();


            // Initialise stuff
            btnLogout.Enabled = false;
        }

        //Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
        }

        //Join button which displays the name entered
        private void btnJoin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello " + txtFirstName.Text + " " + txtLastName.Text;
        }

        //Currency Converter
        private void btnConvert_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtFromCurrency.Text);
            double convertedamount = amount * 1.2;


            txtToCurrency.Text = convertedamount.ToString();
        }
    }
}
