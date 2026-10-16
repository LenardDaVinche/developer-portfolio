namespace WindowsFormsApplication1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCostVAT = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudOver18 = new System.Windows.Forms.NumericUpDown();
            this.nudUnder18 = new System.Windows.Forms.NumericUpDown();
            this.chkFood = new System.Windows.Forms.CheckBox();
            this.chkBand = new System.Windows.Forms.CheckBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBooking = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lblCostNumber = new System.Windows.Forms.Label();
            this.lblCostVATNumber = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOver18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnder18)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalNumber);
            this.panel1.Controls.Add(this.lblCostVATNumber);
            this.panel1.Controls.Add(this.lblCostNumber);
            this.panel1.Controls.Add(this.lblTotalCost);
            this.panel1.Controls.Add(this.lblCostVAT);
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudOver18);
            this.panel1.Controls.Add(this.nudUnder18);
            this.panel1.Controls.Add(this.chkFood);
            this.panel1.Controls.Add(this.chkBand);
            this.panel1.Controls.Add(this.lblVenue);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 953);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalCost.Location = new System.Drawing.Point(72, 868);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(152, 36);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // lblCostVAT
            // 
            this.lblCostVAT.AutoSize = true;
            this.lblCostVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCostVAT.Location = new System.Drawing.Point(72, 738);
            this.lblCostVAT.Name = "lblCostVAT";
            this.lblCostVAT.Size = new System.Drawing.Size(180, 36);
            this.lblCostVAT.TabIndex = 9;
            this.lblCostVAT.Text = "Cost (VAT): ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCost.Location = new System.Drawing.Point(72, 674);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(238, 36);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost (VAT free): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(204, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "18 and over";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(204, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Under 18s";
            // 
            // nudOver18
            // 
            this.nudOver18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudOver18.Location = new System.Drawing.Point(78, 452);
            this.nudOver18.Name = "nudOver18";
            this.nudOver18.Size = new System.Drawing.Size(120, 38);
            this.nudOver18.TabIndex = 5;
            // 
            // nudUnder18
            // 
            this.nudUnder18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudUnder18.Location = new System.Drawing.Point(78, 374);
            this.nudUnder18.Name = "nudUnder18";
            this.nudUnder18.Size = new System.Drawing.Size(120, 38);
            this.nudUnder18.TabIndex = 4;
            // 
            // chkFood
            // 
            this.chkFood.AutoSize = true;
            this.chkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkFood.Location = new System.Drawing.Point(78, 540);
            this.chkFood.Name = "chkFood";
            this.chkFood.Size = new System.Drawing.Size(116, 40);
            this.chkFood.TabIndex = 3;
            this.chkFood.Text = "Food";
            this.chkFood.UseVisualStyleBackColor = true;
            // 
            // chkBand
            // 
            this.chkBand.AutoSize = true;
            this.chkBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkBand.Location = new System.Drawing.Point(78, 277);
            this.chkBand.Name = "chkBand";
            this.chkBand.Size = new System.Drawing.Size(177, 40);
            this.chkBand.TabIndex = 2;
            this.chkBand.Text = "Live band";
            this.chkBand.UseVisualStyleBackColor = true;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVenue.Location = new System.Drawing.Point(72, 174);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(478, 36);
            this.lblVenue.TabIndex = 1;
            this.lblVenue.Text = "The venue has a fixed cost of £500";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(65, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(684, 76);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Party Cost Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBooking);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(845, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 953);
            this.panel2.TabIndex = 1;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(78, 22);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(434, 76);
            this.lblBooking.TabIndex = 1;
            this.lblBooking.Text = "Booking date";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(91, 315);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lblCostNumber
            // 
            this.lblCostNumber.AutoSize = true;
            this.lblCostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCostNumber.Location = new System.Drawing.Point(419, 674);
            this.lblCostNumber.Name = "lblCostNumber";
            this.lblCostNumber.Size = new System.Drawing.Size(49, 36);
            this.lblCostNumber.TabIndex = 11;
            this.lblCostNumber.Text = "£0";
            // 
            // lblCostVATNumber
            // 
            this.lblCostVATNumber.AutoSize = true;
            this.lblCostVATNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCostVATNumber.Location = new System.Drawing.Point(419, 738);
            this.lblCostVATNumber.Name = "lblCostVATNumber";
            this.lblCostVATNumber.Size = new System.Drawing.Size(49, 36);
            this.lblCostVATNumber.TabIndex = 12;
            this.lblCostVATNumber.Text = "£0";
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalNumber.Location = new System.Drawing.Point(419, 868);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(49, 36);
            this.lblTotalNumber.TabIndex = 13;
            this.lblTotalNumber.Text = "£0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 953);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Cost Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOver18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnder18)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblCostVAT;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudOver18;
        private System.Windows.Forms.NumericUpDown nudUnder18;
        private System.Windows.Forms.CheckBox chkFood;
        private System.Windows.Forms.CheckBox chkBand;
        private System.Windows.Forms.Label lblBooking;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblCostVATNumber;
        private System.Windows.Forms.Label lblCostNumber;
    }
}

