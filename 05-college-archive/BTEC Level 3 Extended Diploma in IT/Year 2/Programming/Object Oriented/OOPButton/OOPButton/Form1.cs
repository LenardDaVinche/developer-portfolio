using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random gen;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();

            gen = new Random(DateTime.Now.Millisecond);

            buttons = new List<Button> { };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLbl_NewButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Button somebutton = new Button();
                somebutton.BackColor = Color.Aquamarine;
                somebutton.Text = i.ToString();
                somebutton.Height = 50;
                somebutton.Width = 50;
                somebutton.Top = gen.Next(0, this.Height - somebutton.Height);
                somebutton.Left = gen.Next(0, this.Width - somebutton.Width);
                somebutton.Parent = this;
                this.Refresh();
            }

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Button button in buttons)
            {
                button.Left += 1;
            }
        }
    }
}

