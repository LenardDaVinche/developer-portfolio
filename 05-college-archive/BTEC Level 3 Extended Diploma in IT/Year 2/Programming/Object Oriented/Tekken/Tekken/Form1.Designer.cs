namespace Tekken
{
    partial class Form1
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
            this.lbkNewGame = new System.Windows.Forms.LinkLabel();
            this.grpAttacker = new System.Windows.Forms.GroupBox();
            this.btnAttKing = new System.Windows.Forms.Button();
            this.btnAttYoshi = new System.Windows.Forms.Button();
            this.btnAttSteve = new System.Windows.Forms.Button();
            this.btnAttJin = new System.Windows.Forms.Button();
            this.btnAttMarshallLaw = new System.Windows.Forms.Button();
            this.grpDefender = new System.Windows.Forms.GroupBox();
            this.btnDefSteve = new System.Windows.Forms.Button();
            this.btnDefYoshi = new System.Windows.Forms.Button();
            this.btnDefKing = new System.Windows.Forms.Button();
            this.btnDefJin = new System.Windows.Forms.Button();
            this.btnDefMarshallLaw = new System.Windows.Forms.Button();
            this.btnBattle = new System.Windows.Forms.Button();
            this.grpAttacker.SuspendLayout();
            this.grpDefender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbkNewGame
            // 
            this.lbkNewGame.AutoSize = true;
            this.lbkNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkNewGame.Location = new System.Drawing.Point(917, 542);
            this.lbkNewGame.Name = "lbkNewGame";
            this.lbkNewGame.Size = new System.Drawing.Size(109, 25);
            this.lbkNewGame.TabIndex = 1;
            this.lbkNewGame.TabStop = true;
            this.lbkNewGame.Text = "New Game";
            this.lbkNewGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkNewGame_LinkClicked);
            // 
            // grpAttacker
            // 
            this.grpAttacker.Controls.Add(this.btnAttKing);
            this.grpAttacker.Controls.Add(this.btnAttYoshi);
            this.grpAttacker.Controls.Add(this.btnAttSteve);
            this.grpAttacker.Controls.Add(this.btnAttJin);
            this.grpAttacker.Controls.Add(this.btnAttMarshallLaw);
            this.grpAttacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAttacker.ForeColor = System.Drawing.Color.Red;
            this.grpAttacker.Location = new System.Drawing.Point(72, 49);
            this.grpAttacker.Name = "grpAttacker";
            this.grpAttacker.Size = new System.Drawing.Size(340, 425);
            this.grpAttacker.TabIndex = 2;
            this.grpAttacker.TabStop = false;
            this.grpAttacker.Text = "Select Attacker";
            // 
            // btnAttKing
            // 
            this.btnAttKing.Location = new System.Drawing.Point(27, 163);
            this.btnAttKing.Name = "btnAttKing";
            this.btnAttKing.Size = new System.Drawing.Size(277, 49);
            this.btnAttKing.TabIndex = 4;
            this.btnAttKing.Text = "King";
            this.btnAttKing.UseVisualStyleBackColor = true;
            this.btnAttKing.Click += new System.EventHandler(this.btnAttKing_Click);
            // 
            // btnAttYoshi
            // 
            this.btnAttYoshi.Location = new System.Drawing.Point(27, 218);
            this.btnAttYoshi.Name = "btnAttYoshi";
            this.btnAttYoshi.Size = new System.Drawing.Size(277, 49);
            this.btnAttYoshi.TabIndex = 3;
            this.btnAttYoshi.Text = "YoshiMitzu";
            this.btnAttYoshi.UseVisualStyleBackColor = true;
            this.btnAttYoshi.Click += new System.EventHandler(this.btnAttYoshi_Click);
            // 
            // btnAttSteve
            // 
            this.btnAttSteve.Location = new System.Drawing.Point(27, 273);
            this.btnAttSteve.Name = "btnAttSteve";
            this.btnAttSteve.Size = new System.Drawing.Size(277, 49);
            this.btnAttSteve.TabIndex = 2;
            this.btnAttSteve.Text = "Steve";
            this.btnAttSteve.UseVisualStyleBackColor = true;
            this.btnAttSteve.Click += new System.EventHandler(this.btnAttSteve_Click);
            // 
            // btnAttJin
            // 
            this.btnAttJin.Location = new System.Drawing.Point(27, 108);
            this.btnAttJin.Name = "btnAttJin";
            this.btnAttJin.Size = new System.Drawing.Size(277, 49);
            this.btnAttJin.TabIndex = 1;
            this.btnAttJin.Text = "Jin";
            this.btnAttJin.UseVisualStyleBackColor = true;
            this.btnAttJin.Click += new System.EventHandler(this.btnAttJin_Click);
            // 
            // btnAttMarshallLaw
            // 
            this.btnAttMarshallLaw.Location = new System.Drawing.Point(27, 53);
            this.btnAttMarshallLaw.Name = "btnAttMarshallLaw";
            this.btnAttMarshallLaw.Size = new System.Drawing.Size(277, 49);
            this.btnAttMarshallLaw.TabIndex = 0;
            this.btnAttMarshallLaw.Text = "Marshall Law";
            this.btnAttMarshallLaw.UseVisualStyleBackColor = true;
            this.btnAttMarshallLaw.Click += new System.EventHandler(this.btnAttMarshallLaw_Click);
            // 
            // grpDefender
            // 
            this.grpDefender.Controls.Add(this.btnDefSteve);
            this.grpDefender.Controls.Add(this.btnDefYoshi);
            this.grpDefender.Controls.Add(this.btnDefKing);
            this.grpDefender.Controls.Add(this.btnDefJin);
            this.grpDefender.Controls.Add(this.btnDefMarshallLaw);
            this.grpDefender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDefender.ForeColor = System.Drawing.Color.Red;
            this.grpDefender.Location = new System.Drawing.Point(650, 49);
            this.grpDefender.Name = "grpDefender";
            this.grpDefender.Size = new System.Drawing.Size(344, 425);
            this.grpDefender.TabIndex = 3;
            this.grpDefender.TabStop = false;
            this.grpDefender.Text = "Select Defender";
            // 
            // btnDefSteve
            // 
            this.btnDefSteve.Location = new System.Drawing.Point(38, 273);
            this.btnDefSteve.Name = "btnDefSteve";
            this.btnDefSteve.Size = new System.Drawing.Size(273, 49);
            this.btnDefSteve.TabIndex = 5;
            this.btnDefSteve.Text = "Steve";
            this.btnDefSteve.UseVisualStyleBackColor = true;
            this.btnDefSteve.Click += new System.EventHandler(this.btnDefSteve_Click);
            // 
            // btnDefYoshi
            // 
            this.btnDefYoshi.Location = new System.Drawing.Point(38, 218);
            this.btnDefYoshi.Name = "btnDefYoshi";
            this.btnDefYoshi.Size = new System.Drawing.Size(273, 49);
            this.btnDefYoshi.TabIndex = 4;
            this.btnDefYoshi.Text = "YoshiMitzu";
            this.btnDefYoshi.UseVisualStyleBackColor = true;
            this.btnDefYoshi.Click += new System.EventHandler(this.btnDefYoshi_Click);
            // 
            // btnDefKing
            // 
            this.btnDefKing.Location = new System.Drawing.Point(38, 163);
            this.btnDefKing.Name = "btnDefKing";
            this.btnDefKing.Size = new System.Drawing.Size(273, 49);
            this.btnDefKing.TabIndex = 3;
            this.btnDefKing.Text = "King";
            this.btnDefKing.UseVisualStyleBackColor = true;
            this.btnDefKing.Click += new System.EventHandler(this.btnDefKing_Click);
            // 
            // btnDefJin
            // 
            this.btnDefJin.Location = new System.Drawing.Point(38, 108);
            this.btnDefJin.Name = "btnDefJin";
            this.btnDefJin.Size = new System.Drawing.Size(273, 49);
            this.btnDefJin.TabIndex = 2;
            this.btnDefJin.Text = "Jin";
            this.btnDefJin.UseVisualStyleBackColor = true;
            this.btnDefJin.Click += new System.EventHandler(this.btnDefJin_Click);
            // 
            // btnDefMarshallLaw
            // 
            this.btnDefMarshallLaw.Location = new System.Drawing.Point(38, 53);
            this.btnDefMarshallLaw.Name = "btnDefMarshallLaw";
            this.btnDefMarshallLaw.Size = new System.Drawing.Size(273, 49);
            this.btnDefMarshallLaw.TabIndex = 1;
            this.btnDefMarshallLaw.Text = "Marshall Law";
            this.btnDefMarshallLaw.UseVisualStyleBackColor = true;
            this.btnDefMarshallLaw.Click += new System.EventHandler(this.btnDefMarshallLaw_Click);
            // 
            // btnBattle
            // 
            this.btnBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(467, 190);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(132, 77);
            this.btnBattle.TabIndex = 4;
            this.btnBattle.Text = "BATTLE";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 609);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.grpDefender);
            this.Controls.Add(this.grpAttacker);
            this.Controls.Add(this.lbkNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t E K K e N";
            this.grpAttacker.ResumeLayout(false);
            this.grpDefender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lbkNewGame;
        private System.Windows.Forms.GroupBox grpAttacker;
        private System.Windows.Forms.Button btnAttKing;
        private System.Windows.Forms.Button btnAttYoshi;
        private System.Windows.Forms.Button btnAttSteve;
        private System.Windows.Forms.Button btnAttJin;
        private System.Windows.Forms.Button btnAttMarshallLaw;
        private System.Windows.Forms.GroupBox grpDefender;
        private System.Windows.Forms.Button btnDefSteve;
        private System.Windows.Forms.Button btnDefYoshi;
        private System.Windows.Forms.Button btnDefKing;
        private System.Windows.Forms.Button btnDefJin;
        private System.Windows.Forms.Button btnDefMarshallLaw;
        private System.Windows.Forms.Button btnBattle;
    }
}

