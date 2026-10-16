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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void btnWinClose_Click(object sender, EventArgs e)
        {
            //Creates a new lost form with the variable "Lose"
            //the form will close uppon the button click
            Win Win = new Win();
            this.Close();
        }
    }
}
