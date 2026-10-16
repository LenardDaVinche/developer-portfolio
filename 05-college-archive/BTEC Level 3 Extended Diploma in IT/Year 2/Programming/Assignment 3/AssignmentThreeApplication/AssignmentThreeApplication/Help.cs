using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentThreeApplication
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            //Declaring a now FAQ form as faqfrm, in order to open the FAQ form
            FAQ faqfrm = new FAQ();
            faqfrm.Show();
        }

        private void btnbackToMain_Click(object sender, EventArgs e)
        {
            //Closes the current form, taking the user back to the main menu
            this.Close();
        }

        private void btncloseApp_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }
    }
}

