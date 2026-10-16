using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace platformGame
{
    public partial class Form1 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        int jumpspeed = 10;
        int force = 8;
        int score = 0;

        public Form1()
        {
            InitializeComponent();

            this.Width = 1100;
            this.Height = 1500;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        // This is the key is down function. This will trigger each time the buttons are pressed. 
        // (i.e. when left button is pressed left goes into true, when right button is pressed it changes go right to true)
        // (when spacebar pressed & character isn't jumping, jumping will be changed to true.)


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = false;
            }
        }
        // This function will turn all of the Booleans back to false when the user releases each key.
        // (i.e. When the left is up, it changes left to false. Same applies to right and spacebar.)

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player.Top += jumpspeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            //This is to continuosly drop the player towards the downward direction, imitating a gravity effect.

            if(goleft)
            {
                Player.Left -= 5;
            }

            //If go left variable is true, this is the amount of pixels the character moves continously.

            if(goright)
            {
                Player.Left += 5;
            }

            //If go right variable is true, this is the amount of pixels the character moves continously.

            if (jumping)
            {
                jumpspeed = -12;
                force -= -1;
            }

            //If jumping is true, the jump speed integer will be minus 12. Imitating thrust in the upwards direction, decreasing the force by 1.
            //This is to give a jump limit, to stop the character from flying over everything.

            else
            {
                jumpspeed = 12;
            }

            //Else the character is not jumping, then the jump speed is still 12.

            foreach (Control x in this.Controls)
            {
                if (x.Tag == null) continue;

                if (x is PictureBox & x.Tag.ToString() == "Platform")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        Player.Top = x.Top - Player.Height;
                    }
                }

                // This will enable the picture boxes to be interacted with, in this situation the player's ability to stand on top of them.
                // For each control x, it creates a variable for the windows component, called X and gives it a type of controls.
                //IF x is a type of picturebox and tag is eqals to "platform"
                //IF  play bounds intersect with the bounds of the platform, and out character is not jumping, the integer changes back to 8 and player will be ontop of "platform"

                if (x is PictureBox && x.Tag.ToString() == "Coin")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                //This is the same principle as before, except it is checking the picture box with the tag "coin".
                //This will remove the coin from the screen, and add 1 to the score variable.
            }

            if (Player.Bounds.IntersectsWith(End.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You win");
            }

            // This will show a "you win" message when the player touches the "end" door, which will also stop the timer.


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
