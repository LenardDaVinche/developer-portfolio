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
    public partial class Battle : Form
    {
        //Game data
        //Creates gamedata variable so it can store data to use on others forms found within the application
        GameData gamedata;


        //Battle form is under the GameData class and all the information stored under it
        public Battle(GameData g)
        {
            InitializeComponent();

            //new gamedata parameter, to be used for passing/referecing values to be handled as methods in this specific form
            gamedata = g;

            //Heal program is set to false on launch, making it inaccessable by the user.
            btnHeal.Enabled = false;
        }

        private void btnLightAttack_Click(object sender, EventArgs e)
        {

            //If the Opponent's Progressbar value is less than Light Damage value of the attacking weapon
            //A new win variable is created with the Win form stored within it
            //The win variable is opened as a model diaglog box
            //When the Win form is closed, it will close the battle form
            if (prgOpponent.Value <= gamedata.attackingweopon.LightDamage)
            {
                Win win = new Win();
                win.ShowDialog();
                this.Close();
            }

            //Reduce Opponent Health with weapon damage
            //The damage reduces varies on the "attackingweopon" chosen by the user
            else
            {
                prgOpponent.Value -= gamedata.attackingweopon.LightDamage;
            }

            //If the Player's Progressbar value is less than Light Damage value of the attacking weapon
            //A new lose variable is created with the Lose form stored within it
            //The lose variable is opened as a model diaglog box
            //When the Lose form is closed, it will close the battle form
            if (prgPlayer.Value <= gamedata.attackingweopon.LightDamage)
            {
                Lose lose = new Lose();
                lose.ShowDialog();
                this.Close();
            }

            //Enable the heal button
            //Reduce player health with predefined weapon damage value
            //The damage reduces is the same field to what the player chose for "attackingweopon", but with extra damage
            else
            {
                btnHeal.Enabled = true;
                prgPlayer.Value -= gamedata.attackingweopon.LightDamage * 2;
            }


            // Opacity effect
            //Makes the form transparent until it is 20% visible.
            while (this.Opacity > 0.2)
            {
                this.Opacity -= 0.1;
                System.Threading.Thread.Sleep(20);
            }

            //This adds a 10 millisecond gap between the opacity from decreasing and increasing 
            System.Threading.Thread.Sleep(10);

            //Opacity effect
            //It carries on looping until the opacity is at 1.0, which it will then increase opacity.
            while (this.Opacity < 1.0)
            {
                this.Opacity += 0.1;
                System.Threading.Thread.Sleep(20);
            }

        }

        private void btnHeavyAttack_Click(object sender, EventArgs e)
        {

            //If the Opponent's Progressbar value is less than Heavy Damage value of the attacking weapon
            //A new win variable is created with the Win form stored within it
            //The win variable is opened as a model diaglog box
            //When the Win form is closed, it will close the battle form
            if (prgOpponent.Value <= gamedata.attackingweopon.HeavyDamage)
            {
                Win win = new Win();
                win.ShowDialog();
                this.Close();
            }

            //Reduce Opponent Health with weapon damage
            //The damage reduces varies on the "attackingweopon" chosen by the user
            else
            {
                prgOpponent.Value -= gamedata.attackingweopon.HeavyDamage;
            }

            //If the Player's Progressbar value is less than Heavy Damage value of the attacking weapon
            //A new lose variable is created with the Lose form stored within it
            //The lose variable is opened as a model diaglog box
            //When the Lose form is closed, it will close the battle form
            if (prgPlayer.Value <= gamedata.attackingweopon.HeavyDamage)
            {
                Lose lose = new Lose();
                lose.ShowDialog();
                this.Close();
            }

            //Enable the heal button
            //Reduce player health with predefined weapon damage value
            //The damage reduces is the same field to what the player chose for "attackingweopon", but with extra damage
            else
            {
                btnHeal.Enabled = true;
                prgPlayer.Value -= gamedata.attackingweopon.HeavyDamage + 10;
            }


            //Opacity effect

            //Makes the form transparent until it is 20% visible.
            while (this.Opacity > 0.2)
            {
                this.Opacity -= 0.1;
                System.Threading.Thread.Sleep(40);
            }

            //This adds a 20 millisecond gap between the opacity loop
            System.Threading.Thread.Sleep(30);

            //Opacity effect
            //It carries on looping until the opacity is at 1.0, which it will then increase opacity.
            while (this.Opacity < 1.0)
            {
                this.Opacity += 0.1;
                System.Threading.Thread.Sleep(40);
            }

        }

        //Heal button (when clicked on)
        private void btnHeal_Click(object sender, EventArgs e)
        {
            //This adds +10 value to the Player's progressbar every time btnHeal is clicked
            prgPlayer.Value += 10;

            //Adds +5 value to the opponent's progressbar every time btnHeal is clicked
            prgOpponent.Value += 5;

            //If the progress bar value is above 95, disable btnHeal to prevent the application from crashing
            //Indicate user with a messagebox with a warning stating why btnHeal is disabled
            if (prgPlayer.Value >= 95)
            {
                btnHeal.Enabled = false;
                MessageBox.Show("You have reached maximum healing ability");
            }

        }

    }
}