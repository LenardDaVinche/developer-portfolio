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
    public partial class List : Form
    {
        public List<String> names;
        public List<Int32> numbers;

        private void InkAddToNames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name = txtNames.Text.Trim();

            if (name == "") return;

            if (names.Contains(name))

            {
                MessageBox.Show("It is already within the list");
            }

            else

            {
                names.Add(name);

                lstNames.DataSource = null;
                lstNames.DataSource = names;

            }
        }
        private void lnkDeleteName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lstNames.SelectedItem == null) return;

            string name = lstNames.SelectedItem.ToString();

            if (names.Contains(name))
            {
            names.Remove(name);

            lstNames.DataSource = null;
            lstNames.DataSource = names;
            }


        }

        
    }

}
