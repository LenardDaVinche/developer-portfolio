namespace AssignmentThreeApplication
{
    partial class Battle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prgPlayer = new System.Windows.Forms.ProgressBar();
            this.prgOpponent = new System.Windows.Forms.ProgressBar();
            this.pnlbuttonMenu = new System.Windows.Forms.Panel();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnHeavyAttack = new System.Windows.Forms.Button();
            this.btnLightAttack = new System.Windows.Forms.Button();
            this.picopponent = new System.Windows.Forms.PictureBox();
            this.picplayer = new System.Windows.Forms.PictureBox();
            this.lblBattlePlayer = new System.Windows.Forms.Label();
            this.lblBattleOpponent = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblOpponentHealth = new System.Windows.Forms.Label();
            this.pnlbuttonMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picopponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // prgPlayer
            // 
            this.prgPlayer.Location = new System.Drawing.Point(186, 398);
            this.prgPlayer.Name = "prgPlayer";
            this.prgPlayer.Size = new System.Drawing.Size(285, 39);
            this.prgPlayer.TabIndex = 0;
            this.prgPlayer.Value = 100;
            // 
            // prgOpponent
            // 
            this.prgOpponent.Location = new System.Drawing.Point(963, 348);
            this.prgOpponent.Name = "prgOpponent";
            this.prgOpponent.Size = new System.Drawing.Size(333, 39);
            this.prgOpponent.TabIndex = 6;
            this.prgOpponent.Value = 100;
            // 
            // pnlbuttonMenu
            // 
            this.pnlbuttonMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlbuttonMenu.Controls.Add(this.btnHeal);
            this.pnlbuttonMenu.Controls.Add(this.btnHeavyAttack);
            this.pnlbuttonMenu.Controls.Add(this.btnLightAttack);
            this.pnlbuttonMenu.Location = new System.Drawing.Point(12, 753);
            this.pnlbuttonMenu.Name = "pnlbuttonMenu";
            this.pnlbuttonMenu.Size = new System.Drawing.Size(1399, 100);
            this.pnlbuttonMenu.TabIndex = 9;
            // 
            // btnHeal
            // 
            this.btnHeal.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.btnHeal.Location = new System.Drawing.Point(1079, 15);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(205, 74);
            this.btnHeal.TabIndex = 25;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnHeavyAttack
            // 
            this.btnHeavyAttack.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.btnHeavyAttack.Location = new System.Drawing.Point(574, 15);
            this.btnHeavyAttack.Name = "btnHeavyAttack";
            this.btnHeavyAttack.Size = new System.Drawing.Size(267, 74);
            this.btnHeavyAttack.TabIndex = 24;
            this.btnHeavyAttack.Text = "Heavy Attack";
            this.btnHeavyAttack.UseVisualStyleBackColor = true;
            this.btnHeavyAttack.Click += new System.EventHandler(this.btnHeavyAttack_Click);
            // 
            // btnLightAttack
            // 
            this.btnLightAttack.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.btnLightAttack.Location = new System.Drawing.Point(85, 15);
            this.btnLightAttack.Name = "btnLightAttack";
            this.btnLightAttack.Size = new System.Drawing.Size(267, 74);
            this.btnLightAttack.TabIndex = 22;
            this.btnLightAttack.Text = "Light Attack";
            this.btnLightAttack.UseVisualStyleBackColor = true;
            this.btnLightAttack.Click += new System.EventHandler(this.btnLightAttack_Click);
            // 
            // picopponent
            // 
            this.picopponent.BackColor = System.Drawing.Color.Transparent;
            this.picopponent.Image = global::AssignmentThreeApplication.Properties.Resources.UnrealisticInformalGoshawk_max_1mb;
            this.picopponent.Location = new System.Drawing.Point(963, 398);
            this.picopponent.Name = "picopponent";
            this.picopponent.Size = new System.Drawing.Size(333, 312);
            this.picopponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picopponent.TabIndex = 10;
            this.picopponent.TabStop = false;
            // 
            // picplayer
            // 
            this.picplayer.BackColor = System.Drawing.Color.Transparent;
            this.picplayer.Image = global::AssignmentThreeApplication.Properties.Resources.knight_animation_by_laisdossin_d9cweny;
            this.picplayer.Location = new System.Drawing.Point(186, 467);
            this.picplayer.Name = "picplayer";
            this.picplayer.Size = new System.Drawing.Size(285, 243);
            this.picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picplayer.TabIndex = 11;
            this.picplayer.TabStop = false;
            // 
            // lblBattlePlayer
            // 
            this.lblBattlePlayer.AutoSize = true;
            this.lblBattlePlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlePlayer.Font = new System.Drawing.Font("Trajan Pro", 17F);
            this.lblBattlePlayer.Location = new System.Drawing.Point(176, 189);
            this.lblBattlePlayer.Name = "lblBattlePlayer";
            this.lblBattlePlayer.Size = new System.Drawing.Size(188, 58);
            this.lblBattlePlayer.TabIndex = 12;
            this.lblBattlePlayer.Text = "Player";
            // 
            // lblBattleOpponent
            // 
            this.lblBattleOpponent.AutoSize = true;
            this.lblBattleOpponent.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleOpponent.Font = new System.Drawing.Font("Trajan Pro", 17F);
            this.lblBattleOpponent.Location = new System.Drawing.Point(953, 189);
            this.lblBattleOpponent.Name = "lblBattleOpponent";
            this.lblBattleOpponent.Size = new System.Drawing.Size(282, 58);
            this.lblBattleOpponent.TabIndex = 13;
            this.lblBattleOpponent.Text = "Opponent";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.lblHealth.Location = new System.Drawing.Point(179, 357);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(139, 38);
            this.lblHealth.TabIndex = 14;
            this.lblHealth.Text = "Health";
            // 
            // lblOpponentHealth
            // 
            this.lblOpponentHealth.AutoSize = true;
            this.lblOpponentHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblOpponentHealth.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.lblOpponentHealth.Location = new System.Drawing.Point(956, 307);
            this.lblOpponentHealth.Name = "lblOpponentHealth";
            this.lblOpponentHealth.Size = new System.Drawing.Size(139, 38);
            this.lblOpponentHealth.TabIndex = 15;
            this.lblOpponentHealth.Text = "Health";
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::AssignmentThreeApplication.Properties.Resources._309824_8_bit_wallpaper_1920x1080_720p;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1423, 857);
            this.Controls.Add(this.lblOpponentHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblBattleOpponent);
            this.Controls.Add(this.lblBattlePlayer);
            this.Controls.Add(this.picplayer);
            this.Controls.Add(this.picopponent);
            this.Controls.Add(this.pnlbuttonMenu);
            this.Controls.Add(this.prgOpponent);
            this.Controls.Add(this.prgPlayer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Battle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle";
            this.pnlbuttonMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picopponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgPlayer;
        private System.Windows.Forms.ProgressBar prgOpponent;
        private System.Windows.Forms.Panel pnlbuttonMenu;
        private System.Windows.Forms.Button btnLightAttack;
        private System.Windows.Forms.PictureBox picopponent;
        private System.Windows.Forms.PictureBox picplayer;
        private System.Windows.Forms.Button btnHeavyAttack;
        private System.Windows.Forms.Label lblBattlePlayer;
        private System.Windows.Forms.Label lblBattleOpponent;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblOpponentHealth;
        private System.Windows.Forms.Button btnHeal;
    }
}