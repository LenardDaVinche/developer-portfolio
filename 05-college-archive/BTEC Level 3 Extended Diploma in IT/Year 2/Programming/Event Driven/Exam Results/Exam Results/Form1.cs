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

        private string CalculateGrade(int Mark)
        {
            string Grade = "F";

            int mark = Convert.ToInt32(nudEnglish.Value);

            if (mark < 50) ;
            {
                Grade = "F";
            }
            else if (mark >= 50 && mark <= 59) ;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
