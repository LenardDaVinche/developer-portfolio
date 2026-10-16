namespace AFirstLookAtOOP
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
            this.lblOutcomes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiantOneAttack
            // 
            this.btnGiantOneAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiantOneAttack.Location = new System.Drawing.Point(203, 157);
            this.btnGiantOneAttack.Name = "btnGiantOneAttack";
            this.btnGiantOneAttack.Size = new System.Drawing.Size(285, 213);
            this.btnGiantOneAttack.TabIndex = 0;
            this.btnGiantOneAttack.Text = "Giant 1 Attack";
            this.btnGiantOneAttack.UseVisualStyleBackColor = true;
            // 
            // btnGiantTwoAttack
            // 
            this.btnGiantTwoAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiantTwoAttack.Location = new System.Drawing.Point(817, 157);
            this.btnGiantTwoAttack.Name = "btnGiantTwoAttack";
            this.btnGiantTwoAttack.Size = new System.Drawing.Size(285, 213);
            this.btnGiantTwoAttack.TabIndex = 1;
            this.btnGiantTwoAttack.Text = "Giant 2 Attack";
            this.btnGiantTwoAttack.UseVisualStyleBackColor = true;
            // 
            // lblOutcomes
            // 
            this.lblOutcomes.AutoSize = true;
            this.lblOutcomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcomes.Location = new System.Drawing.Point(586, 583);
            this.lblOutcomes.Name = "lblOutcomes";
            this.lblOutcomes.Size = new System.Drawing.Size(219, 55);
            this.lblOutcomes.TabIndex = 2;
            this.lblOutcomes.Text = "Outcome";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1421, 946);
            this.Controls.Add(this.lblOutcomes);
            this.Controls.Add(this.btnGiantTwoAttack);
            this.Controls.Add(this.btnGiantOneAttack);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGiant1Attack;
        private System.Windows.Forms.Button btnGiant2Attack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiant1Att;
        private System.Windows.Forms.Button btnGiant2Att;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnGiantOneAttack;
        private System.Windows.Forms.Button btnGiantTwoAttack;
        private System.Windows.Forms.Label lblOutcomes;
    }
}

