using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MyButton : Button
    {
        public MyButton(Control parent)
        {
            this.Text = "MyButton";
            this.Parent = parent;
            this.Click += new System.EventHandler(this.btn_Click);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Text = "Clicked";
            this.Refresh();
            System.Threading.Thread.Sleep(500);
            this.Text = "MyButton";
            this.Refresh();
        }
    }
}
