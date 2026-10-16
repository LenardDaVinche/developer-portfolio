using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tekken
{
    // SUGGESTED IMPROVEMENTS THAT YOU COULD MAKE
    //  (in increasing level of difficulty)
    //
    // 1. Prevent user from selecting the same person 
    //    as Attacker and Defender
    //
    // 2. Show image of Attacker and Defender when selected
    //    (hint: see Week7_Ex_Images.zip for ideas on 
    //     working with Images in C#)
    //
    // 3. Change images of Attacker and Defender after an
    //    attack (so a before, and an after, image)
    //
    // 4. Implement Punch() and Kick() methods (virtual in the base 
    //    class (Fighter), and override in the derived classes.
    //    There methods could do something fun. It's up to you.
    //
    //
     
    public partial class Form1 : Form
    {
        MarshallLaw marshalllaw;
        Jin jin;
        King king;
        YoshiMitzu yoshimitsu;
        Steve steve;

        Fighter attacker;
        Fighter defender;

        public Form1()
        {
            InitializeComponent();

            grpAttacker.Enabled = false;
            grpDefender.Enabled = false;
            btnBattle.Enabled = false;
        }

        private void lbkNewGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create 5 instances, one for each fighter
            marshalllaw = new MarshallLaw();
            marshalllaw.Name = "Marshall Law";
            marshalllaw.Damage = 104;
            marshalllaw.Hitpoints = 345;

            jin = new Jin();
            jin.Name = "Jin";
            jin.Damage = 56;
            jin.Hitpoints = 485;

            king = new King();
            king.Name = "King";
            king.Damage = 101;
            king.Hitpoints = 265;

            yoshimitsu = new YoshiMitzu();
            yoshimitsu.Name = "Yoshi Mitsu";
            yoshimitsu.Damage = 88;
            yoshimitsu.Hitpoints = 380;

            steve = new Steve();
            steve.Name = "Steve";
            steve.Damage = 95;
            steve.Hitpoints = 375;

            // Enable character selection and attack
            grpAttacker.Enabled = true;
            grpDefender.Enabled = true;
            btnBattle.Enabled = true;

            // Label buttons
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            btnAttMarshallLaw.Text = marshalllaw.ToString();
            btnAttJin.Text = jin.ToString();
            btnAttKing.Text = king.ToString();
            btnAttSteve.Text = steve.ToString();
            btnAttYoshi.Text = yoshimitsu.ToString();

            btnDefMarshallLaw.Text = marshalllaw.ToString();
            btnDefJin.Text = jin.ToString();
            btnDefKing.Text = king.ToString();
            btnDefSteve.Text = steve.ToString();
            btnDefYoshi.Text = yoshimitsu.ToString();
        }
        private void btnAttMarshallLaw_Click(object sender, EventArgs e)
        {
            attacker = marshalllaw;
        }

        private void btnAttJin_Click(object sender, EventArgs e)
        {
            attacker = jin;
        }

        private void btnAttKing_Click(object sender, EventArgs e)
        {
            attacker = king;
        }

        private void btnAttYoshi_Click(object sender, EventArgs e)
        {
            attacker = yoshimitsu;
        }

        private void btnAttSteve_Click(object sender, EventArgs e)
        {
            attacker = steve;
        }

        private void btnDefMarshallLaw_Click(object sender, EventArgs e)
        {
            defender = marshalllaw;
        }

        private void btnDefJin_Click(object sender, EventArgs e)
        {
            defender = jin;
        }

        private void btnDefKing_Click(object sender, EventArgs e)
        {
            defender = king;
        }

        private void btnDefYoshi_Click(object sender, EventArgs e)
        {
            defender = yoshimitsu;
        }

        private void btnDefSteve_Click(object sender, EventArgs e)
        {
            defender = steve;
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            if (attacker == null)
            {
                MessageBox.Show("Select an attacker");
                return;
            }

            if (defender == null)
            {
                MessageBox.Show("Select a defender");
                return;
            }

            defender.Hitpoints -= attacker.Damage;
            attacker.Hitpoints -= defender.Damage;

            // Update button labels
            UpdateLabels();

            // Player with most Hitpoints left wins
            if (defender.Hitpoints == attacker.Hitpoints)
            {
                MessageBox.Show("DRAW !!!");
            }
            else if (defender.Hitpoints > attacker.Hitpoints)
            {
                MessageBox.Show(defender.Name + " WINS");
            }
            else 
            {
                MessageBox.Show(attacker.Name + " WINS");
            }

            // Death to either attacker or defender?
            if (attacker.Hitpoints < 1) btnBattle.Enabled = false;
            if (defender.Hitpoints < 1) btnBattle.Enabled = false;
        }
    }
}
