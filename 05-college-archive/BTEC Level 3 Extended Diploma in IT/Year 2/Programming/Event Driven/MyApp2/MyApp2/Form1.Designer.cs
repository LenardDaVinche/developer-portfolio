namespace WindowsFormsApplication1
{
    partial class MyApp2
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(322, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(447, 396);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(983, 115);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(447, 396);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(769, 650);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(407, 31);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(585, 656);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(107, 25);
            this.lblFirstname.TabIndex = 3;
            this.lblFirstname.Text = "Firstname";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(769, 730);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(407, 31);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(585, 733);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 25);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "Lastname";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMessage.Location = new System.Drawing.Point(546, 851);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(145, 37);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Message";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(224, 851);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(179, 89);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.Location = new System.Drawing.Point(571, 1025);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.Size = new System.Drawing.Size(100, 31);
            this.txtFromCurrency.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.Location = new System.Drawing.Point(921, 1025);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.Size = new System.Drawing.Size(100, 31);
            this.txtToCurrency.TabIndex = 10;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(739, 1018);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(115, 44);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // MyApp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1156);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtToCurrency);
            this.Controls.Add(this.txtFromCurrency);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Name = "MyApp2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TextBox txtFromCurrency;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtToCurrency;
        private System.Windows.Forms.Button btnConvert;
    }
}

