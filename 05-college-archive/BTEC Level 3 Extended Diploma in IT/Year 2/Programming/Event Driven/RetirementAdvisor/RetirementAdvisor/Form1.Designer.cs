namespace WindowsFormsApplication1
{
    partial class RetirementAdvisor
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
            this.picClipart = new System.Windows.Forms.PictureBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picClipart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // picClipart
            // 
            this.picClipart.Location = new System.Drawing.Point(964, 122);
            this.picClipart.Margin = new System.Windows.Forms.Padding(6);
            this.picClipart.Name = "picClipart";
            this.picClipart.Size = new System.Drawing.Size(643, 514);
            this.picClipart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClipart.TabIndex = 10;
            this.picClipart.TabStop = false;
            // 
            // txtResponse
            // 
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtResponse.Location = new System.Drawing.Point(55, 688);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(6);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(1552, 317);
            this.txtResponse.TabIndex = 9;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(44, 122);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(565, 65);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "How old are you currently?";
            // 
            // nudAge
            // 
            this.nudAge.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge.Location = new System.Drawing.Point(394, 319);
            this.nudAge.Margin = new System.Windows.Forms.Padding(6);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(215, 71);
            this.nudAge.TabIndex = 6;
            // 
            // RetirementAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1052);
            this.Controls.Add(this.picClipart);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.nudAge);
            this.Name = "RetirementAdvisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirement";
            ((System.ComponentModel.ISupportInitialize)(this.picClipart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClipart;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.NumericUpDown nudAge;
    }
}

