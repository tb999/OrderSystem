namespace OrderSystem
{
    partial class LoginForm
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
            this.OrderSystemlbl = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Resetpassll = new System.Windows.Forms.LinkLabel();
            this.Resetpasslbl = new System.Windows.Forms.Label();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderSystemlbl
            // 
            this.OrderSystemlbl.AutoSize = true;
            this.OrderSystemlbl.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSystemlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderSystemlbl.Location = new System.Drawing.Point(446, 58);
            this.OrderSystemlbl.Name = "OrderSystemlbl";
            this.OrderSystemlbl.Size = new System.Drawing.Size(263, 38);
            this.OrderSystemlbl.TabIndex = 0;
            this.OrderSystemlbl.Text = "Order System";
            this.OrderSystemlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(644, 226);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(113, 137);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(392, 226);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(234, 46);
            this.Usernametxt.TabIndex = 0;
            this.Usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(392, 317);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(234, 46);
            this.Passwordtxt.TabIndex = 1;
            this.Passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usernamelbl.Location = new System.Drawing.Point(389, 196);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(138, 25);
            this.Usernamelbl.TabIndex = 5;
            this.Usernamelbl.Text = "Username:";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Passwordlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Passwordlbl.Location = new System.Drawing.Point(389, 289);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(133, 25);
            this.Passwordlbl.TabIndex = 6;
            this.Passwordlbl.Text = "Password:";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(22, 623);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(127, 77);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Resetpassll
            // 
            this.Resetpassll.AutoSize = true;
            this.Resetpassll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Resetpassll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetpassll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Resetpassll.LinkColor = System.Drawing.Color.DarkRed;
            this.Resetpassll.Location = new System.Drawing.Point(696, 376);
            this.Resetpassll.Name = "Resetpassll";
            this.Resetpassll.Size = new System.Drawing.Size(38, 16);
            this.Resetpassll.TabIndex = 3;
            this.Resetpassll.TabStop = true;
            this.Resetpassll.Text = "Here";
            this.Resetpassll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Resetpassll_LinkClicked);
            // 
            // Resetpasslbl
            // 
            this.Resetpasslbl.AutoSize = true;
            this.Resetpasslbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Resetpasslbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetpasslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Resetpasslbl.Location = new System.Drawing.Point(413, 376);
            this.Resetpasslbl.Name = "Resetpasslbl";
            this.Resetpasslbl.Size = new System.Drawing.Size(286, 16);
            this.Resetpasslbl.TabIndex = 9;
            this.Resetpasslbl.Text = "If you have forgotten your password click";
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Statuslbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Statuslbl.Location = new System.Drawing.Point(918, 654);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(219, 16);
            this.Statuslbl.TabIndex = 0;
            this.Statuslbl.Text = "You are currently not logged in.";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.Resetpasslbl);
            this.Controls.Add(this.Resetpassll);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.OrderSystemlbl);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderSystemlbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.LinkLabel Resetpassll;
        private System.Windows.Forms.Label Resetpasslbl;
        private System.Windows.Forms.Label Statuslbl;
    }
}

