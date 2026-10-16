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
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            //Creates a new list of strings, which are referenced as questions as a local variable
            List<string> questions = new List<string>();
            questions.Add("Can I have more than one weapon?");
            questions.Add("How do I know what weapons the enemy has?");
            questions.Add("Does the enemy have the same health as I do?");
            questions.Add("Is the damage from the enemy randonly generated?");
            questions.Add("Why can't I pick another weapon after I have finished a battle?");
            questions.Add("Both me and the opponent died at the same time, what does it mean?");
            questions.Add("How does the Scoring of the game work?");

            //gets or sets the source of the data within the list 
            listFAQ.DataSource = questions;
        }

        private void listFAQ_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if statements used to answer each of the selected questions listed

            //If the SelectedIndex laballed as 0 is selected, create the text on Answer text box
            if (listFAQ.SelectedIndex == 0)
            {
                txtAnswer.Text = "No, it isn't possible to have more than one weapon within a fight.";
            }
            //If the SelectedIndex laballed as 1 is selected, create the text on Answer text box
            else if (listFAQ.SelectedIndex == 1)
            {
                txtAnswer.Text = "The weapons that you choose in the main menu is what the enemy will also have";
            }
            //If the SelectedIndex laballed as 2 is selected, create the text on Answer text box
            else if (listFAQ.SelectedIndex == 2)
            {
                txtAnswer.Text = "Yes, the enemy will have 100 health points, equal that to yours";
            }
            //If the SelectedIndex laballed as 3 is selected, create the text on Answer text box
            else if (listFAQ.SelectedIndex == 3)
            {
                txtAnswer.Text = "No, the damage the enemy does to you is twice the amount you do to him, so be cautious";
            }
            //If the SelectedIndex laballed as 4 is selected, create the text on Answer text box
            else if (listFAQ.SelectedIndex == 4)
            {
                txtAnswer.Text = "You will need to press the New Game button in order to pick another weapon and start again";
            }
            //If the SelectedIndex laballed as 5 is selected, create the text on Answer text box
            else if (listFAQ.SelectedIndex == 5)
            {
                txtAnswer.Text = "It means that both of you each get the score of beating the opponent, since the game is focused on killing the opponent rather than who still lives";
            }
            //If the SelectedIndex laballed as 6 is selected, create the text on Answer text box
            else if (listFAQ.SelectedIndex == 6)
            {
                txtAnswer.Text = "There isn't a dedicated score system, instead the score is the win or lose screen shown at the end of a battle.";
            }
        }
    }
}
