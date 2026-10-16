namespace AFirstLookAtOO
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
            this.btnGiantOneAttack = new System.Windows.Forms.Button();
            this.btnGiantTwoAttack = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnArcherTwoAttack = new System.Windows.Forms.Button();
            this.btnArcherOneAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiantOneAttack
            // 
            this.btnGiantOneAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiantOneAttack.Location = new System.Drawing.Point(144, 81);
            this.btnGiantOneAttack.Name = "btnGiantOneAttack";
            this.btnGiantOneAttack.Size = new System.Drawing.Size(238, 199);
            this.btnGiantOneAttack.TabIndex = 0;
            this.btnGiantOneAttack.Text = "Giant 1 Attack";
            this.btnGiantOneAttack.UseVisualStyleBackColor = true;
            this.btnGiantOneAttack.Click += new System.EventHandler(this.btnGiantOneAttack_Click);
            // 
            // btnGiantTwoAttack
            // 
            this.btnGiantTwoAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiantTwoAttack.Location = new System.Drawing.Point(762, 81);
            this.btnGiantTwoAttack.Name = "btnGiantTwoAttack";
            this.btnGiantTwoAttack.Size = new System.Drawing.Size(238, 199);
            this.btnGiantTwoAttack.TabIndex = 1;
            this.btnGiantTwoAttack.Text = "Giant 2 Attack";
            this.btnGiantTwoAttack.UseVisualStyleBackColor = true;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(459, 870);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(219, 55);
            this.lblOutcome.TabIndex = 2;
            this.lblOutcome.Text = "Outcome";
            // 
            // btnArcherTwoAttack
            // 
            this.btnArcherTwoAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcherTwoAttack.Location = new System.Drawing.Point(762, 493);
            this.btnArcherTwoAttack.Name = "btnArcherTwoAttack";
            this.btnArcherTwoAttack.Size = new System.Drawing.Size(238, 199);
            this.btnArcherTwoAttack.TabIndex = 3;
            this.btnArcherTwoAttack.Text = "Archer 2 Attack";
            this.btnArcherTwoAttack.UseVisualStyleBackColor = true;
            // 
            // btnArcherOneAttack
            // 
            this.btnArcherOneAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcherOneAttack.Location = new System.Drawing.Point(144, 493);
            this.btnArcherOneAttack.Name = "btnArcherOneAttack";
            this.btnArcherOneAttack.Size = new System.Drawing.Size(238, 199);
            this.btnArcherOneAttack.TabIndex = 3;
            this.btnArcherOneAttack.Text = "Archer 1 Attack";
            this.btnArcherOneAttack.UseVisualStyleBackColor = true;
            this.btnArcherOneAttack.Click += new System.EventHandler(this.btnArcherOneAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 985);
            this.Controls.Add(this.btnArcherOneAttack);
            this.Controls.Add(this.btnArcherTwoAttack);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnGiantTwoAttack);
            this.Controls.Add(this.btnGiantOneAttack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiantOneAttack;
        private System.Windows.Forms.Button btnGiantTwoAttack;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnArcherTwoAttack;
        private System.Windows.Forms.Button btnArcherOneAttack;
    }
}

