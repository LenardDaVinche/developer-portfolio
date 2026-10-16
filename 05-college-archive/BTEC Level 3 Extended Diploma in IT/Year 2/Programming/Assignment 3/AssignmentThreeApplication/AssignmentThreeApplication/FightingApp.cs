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
    public partial class FightingApp : Form
    {
        //Gamedata
        //This is the major variable which stores the data used on the game as "attackingweopon" field
        GameData gamedata;

        public FightingApp()
        {
            InitializeComponent();

            //Gamedata
            //The variable will be used to transfer the stored data of each class referenced in this form
            //to different forms within the Application
            gamedata = new AssignmentThreeApplication.GameData();

            //Disables the battle button from being clicked by the user
            btnBattle.Enabled = false;

        }

        //Help screen
        //Opens another form, which has inscructions and the purpose for the game
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help helpfrm = new Help();
            helpfrm.Show();
        }

        //Open battle form to initiate game
        //Initiates the form which the player can fight the opponent to gain score
        private void btnBattle_Click(object sender, EventArgs e)
        {
            //Open new battle form with gamedata class and it's variables with it
            Battle frm = new Battle(gamedata);
            frm.ShowDialog();
        }

        //After pressing the "new game" button, the buttons will be available for the user to click once again
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Enables the ramaining weapon buttons, to give the user the ability of pressing them
            btnSword.Enabled = true;
            btnDagger.Enabled = true;
            btnSpear.Enabled = true;
            btnJavelin.Enabled = true;
            btnWarhammer.Enabled = true;
            btnBattleAxe.Enabled = true;
            btnBow.Enabled = true;
            btnCrossbow.Enabled = true;

            //Disables the battle button from being clicked by the user
            btnBattle.Enabled = false;

        }
    
        //Attacking Weapons

        private void btnSword_Click(object sender, EventArgs e)
        {
            //Disables the ramaining weapon buttons, to prevent the user from pressing them
            btnDagger.Enabled = false;
            btnSpear.Enabled = false;
            btnJavelin.Enabled = false;
            btnWarhammer.Enabled = false;
            btnBattleAxe.Enabled = false;
            btnBow.Enabled = false;
            btnCrossbow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;
            
            //Creates new "LongSword" class which will be stored within the "gamedata" field.
            gamedata.attackingweopon = new LongSword();
        }

        private void btnDagger_Click(object sender, EventArgs e)
        {
            //Disables the ramaining weapon buttons, to prevent the user from pressing them
            btnSword.Enabled = false;
            btnSpear.Enabled = false;
            btnJavelin.Enabled = false;
            btnWarhammer.Enabled = false;
            btnBattleAxe.Enabled = false;
            btnBow.Enabled = false;
            btnCrossbow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;

            //Creates new "Dagger" class which will be stored within the "gamedata" field.
            gamedata.attackingweopon = new Dagger();
        }

        private void btnSpear_Click(object sender, EventArgs e)
        {
            //Disables the rest of the buttons that comes under "AttackWeapon"
            btnSword.Enabled = false;
            btnDagger.Enabled = false;
            btnJavelin.Enabled = false;
            btnWarhammer.Enabled = false;
            btnBattleAxe.Enabled = false;
            btnBow.Enabled = false;
            btnCrossbow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;

            //Accesses the variables under the "Spear" class, which will be stored within the "gamedata" field
            //to use within the "Battle" form.
            gamedata.attackingweopon = new Spear();
        }

        private void btnJavelin_Click(object sender, EventArgs e)
        {
            //Disables the rest of the buttons that comes under "AttackWeapon"
            btnSword.Enabled = false;
            btnDagger.Enabled = false;
            btnSpear.Enabled = false;
            btnWarhammer.Enabled = false;
            btnBattleAxe.Enabled = false;
            btnBow.Enabled = false;
            btnCrossbow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;

            //Accesses the variables under the "Javelin" class, which will be stored within the "gamedata" field
            //to use within the "Battle" form.
            gamedata.attackingweopon = new Javelin();
        }

        private void btnWarhammer_Click(object sender, EventArgs e)
        {
            //Disables the rest of the buttons that comes under "AttackWeapon"
            btnSword.Enabled = false;
            btnDagger.Enabled = false;
            btnSpear.Enabled = false;
            btnJavelin.Enabled = false;
            btnBattleAxe.Enabled = false;
            btnBow.Enabled = false;
            btnCrossbow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;

            //Accesses the variables under the "Warhammer" class, which will be stored within the "gamedata" field
            //to use within the "Battle" form.
            gamedata.attackingweopon = new Warhammer();
        }

        private void btnBattleAxe_Click(object sender, EventArgs e)
        {
            //Disables the rest of the buttons that comes under "AttackWeapon"
            btnSword.Enabled = false;
            btnDagger.Enabled = false;
            btnSpear.Enabled = false;
            btnJavelin.Enabled = false;
            btnWarhammer.Enabled = false;
            btnBow.Enabled = false;
            btnCrossbow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;

            //Creates new "BattleAxe" class which will be stored within the "gamedata" field.
            gamedata.attackingweopon = new BattleAxe();
        }

        private void btnBow_Click(object sender, EventArgs e)
        {
            //Disables the rest of the buttons that comes under "AttackWeapon"
            btnSword.Enabled = false;
            btnDagger.Enabled = false;
            btnSpear.Enabled = false;
            btnJavelin.Enabled = false;
            btnWarhammer.Enabled = false;
            btnBattleAxe.Enabled = false;
            btnCrossbow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;

            //Creates new "BowAndArrow" class which will be stored within the "gamedata" field.
            gamedata.attackingweopon = new BowAndArrow();
        }

        private void btnCrossbow_Click(object sender, EventArgs e)
        {
            //Disables the rest of the buttons that comes under "AttackWeapon"
            btnSword.Enabled = false;
            btnDagger.Enabled = false;
            btnSpear.Enabled = false;
            btnJavelin.Enabled = false;
            btnWarhammer.Enabled = false;
            btnBattleAxe.Enabled = false;
            btnBow.Enabled = false;

            //Enables the battle button, so it can be clicked by the user
            btnBattle.Enabled = true;

            //Creates new "Crossbow" class which will be stored within the "gamedata" field.
            gamedata.attackingweopon = new Crossbow();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the application when the user presses the "Close" button
            this.Close();
        }

        private void FightingApp_Load(object sender, EventArgs e)
        {

        }
    }
}
