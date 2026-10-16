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
    public partial class RetirementAdvisor : Form
    {
        int age = 0;

        public RetirementAdvisor()
        {
            InitializeComponent();
        }

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {
            age = Convert.ToInt32(nudAge.Value);

            if (age < 18)
            {
                txtResponse.Text = "You are either in School/College or working early, you shouldn't even be worrying about retirement.";
                picClipart.Image = Properties.Resources.study;
            }
            else if (age > 66)
            {
                txtResponse.Text = "You are past your NRD (Normal Retirement Date) and should be worrying about your pension.";
                picClipart.Image = Properties.Resources.retirement;
            }
            else
            {
                int yearsToGo = 66 - age;
                txtResponse.Text = "You have " + yearsToGo.ToString() + " years to go until you reach your average retirement age, you sould be worrying about your income.";
                picClipart.Image = Properties.Resources.work;
            }

        }
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int someage = Convert.ToInt32(nudAge.Text);
                if (someage >= nudAge.Minimum && someage <= nudAge.Maximum)
                {
                    nudAge.Value = Convert.ToDecimal(someage);
                }
            }
            catch
            {
            }
        }
        private void txtResponse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
