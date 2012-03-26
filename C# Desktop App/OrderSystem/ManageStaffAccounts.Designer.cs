namespace OrderSystem
{
    partial class ManageStaffAccounts
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
            this.Homebtn = new System.Windows.Forms.Button();
            this.StaffAccountslbl = new System.Windows.Forms.Label();
            this.CurrentStaffgb = new System.Windows.Forms.GroupBox();
            this.Removebtn = new System.Windows.Forms.Button();
            this.Stafflb = new System.Windows.Forms.ListBox();
            this.AddStaffgb = new System.Windows.Forms.GroupBox();
            this.Rolecb = new System.Windows.Forms.ComboBox();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.Surnamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddStaffbtn = new System.Windows.Forms.Button();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.Username2lbl = new System.Windows.Forms.Label();
            this.Forenametxt = new System.Windows.Forms.TextBox();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.CurrentStaffgb.SuspendLayout();
            this.AddStaffgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Homebtn
            // 
            this.Homebtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebtn.Location = new System.Drawing.Point(22, 623);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(127, 77);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "HOME";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // StaffAccountslbl
            // 
            this.StaffAccountslbl.AutoSize = true;
            this.StaffAccountslbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StaffAccountslbl.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffAccountslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StaffAccountslbl.Location = new System.Drawing.Point(465, 37);
            this.StaffAccountslbl.Name = "StaffAccountslbl";
            this.StaffAccountslbl.Size = new System.Drawing.Size(280, 38);
            this.StaffAccountslbl.TabIndex = 15;
            this.StaffAccountslbl.Text = "Staff Accounts";
            // 
            // CurrentStaffgb
            // 
            this.CurrentStaffgb.Controls.Add(this.Removebtn);
            this.CurrentStaffgb.Controls.Add(this.Stafflb);
            this.CurrentStaffgb.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.CurrentStaffgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentStaffgb.Location = new System.Drawing.Point(771, 143);
            this.CurrentStaffgb.Name = "CurrentStaffgb";
            this.CurrentStaffgb.Size = new System.Drawing.Size(181, 446);
            this.CurrentStaffgb.TabIndex = 0;
            this.CurrentStaffgb.TabStop = false;
            this.CurrentStaffgb.Text = "Current Staff";
            // 
            // Removebtn
            // 
            this.Removebtn.ForeColor = System.Drawing.Color.DarkRed;
            this.Removebtn.Location = new System.Drawing.Point(15, 402);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(148, 38);
            this.Removebtn.TabIndex = 0;
            this.Removebtn.Text = "REMOVE SELECTED";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // Stafflb
            // 
            this.Stafflb.FormattingEnabled = true;
            this.Stafflb.Location = new System.Drawing.Point(15, 32);
            this.Stafflb.Name = "Stafflb";
            this.Stafflb.Size = new System.Drawing.Size(148, 355);
            this.Stafflb.TabIndex = 0;
            // 
            // AddStaffgb
            // 
            this.AddStaffgb.Controls.Add(this.Rolecb);
            this.AddStaffgb.Controls.Add(this.Phonelbl);
            this.AddStaffgb.Controls.Add(this.Phonetxt);
            this.AddStaffgb.Controls.Add(this.Rolelbl);
            this.AddStaffgb.Controls.Add(this.Surnametxt);
            this.AddStaffgb.Controls.Add(this.Surnamelbl);
            this.AddStaffgb.Controls.Add(this.label1);
            this.AddStaffgb.Controls.Add(this.AddStaffbtn);
            this.AddStaffgb.Controls.Add(this.FirstNamelbl);
            this.AddStaffgb.Controls.Add(this.Username2lbl);
            this.AddStaffgb.Controls.Add(this.Forenametxt);
            this.AddStaffgb.Controls.Add(this.Usernametxt);
            this.AddStaffgb.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.AddStaffgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStaffgb.Location = new System.Drawing.Point(220, 143);
            this.AddStaffgb.Name = "AddStaffgb";
            this.AddStaffgb.Size = new System.Drawing.Size(483, 446);
            this.AddStaffgb.TabIndex = 0;
            this.AddStaffgb.TabStop = false;
            this.AddStaffgb.Text = "Add New Staff Account";
            // 
            // Rolecb
            // 
            this.Rolecb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Rolecb.FormattingEnabled = true;
            this.Rolecb.Location = new System.Drawing.Point(23, 236);
            this.Rolecb.Name = "Rolecb";
            this.Rolecb.Size = new System.Drawing.Size(149, 26);
            this.Rolecb.TabIndex = 4;
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Phonelbl.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.Phonelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Phonelbl.Location = new System.Drawing.Point(20, 272);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(92, 18);
            this.Phonelbl.TabIndex = 35;
            this.Phonelbl.Text = "Phone No:";
            // 
            // Phonetxt
            // 
            this.Phonetxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Phonetxt.Location = new System.Drawing.Point(23, 293);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(213, 27);
            this.Phonetxt.TabIndex = 5;
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Rolelbl.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.Rolelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rolelbl.Location = new System.Drawing.Point(20, 215);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(50, 18);
            this.Rolelbl.TabIndex = 33;
            this.Rolelbl.Text = "Role:";
            // 
            // Surnametxt
            // 
            this.Surnametxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Surnametxt.Location = new System.Drawing.Point(23, 123);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(186, 27);
            this.Surnametxt.TabIndex = 2;
            // 
            // Surnamelbl
            // 
            this.Surnamelbl.AutoSize = true;
            this.Surnamelbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Surnamelbl.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.Surnamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Surnamelbl.Location = new System.Drawing.Point(20, 97);
            this.Surnamelbl.Name = "Surnamelbl";
            this.Surnamelbl.Size = new System.Drawing.Size(88, 18);
            this.Surnamelbl.TabIndex = 31;
            this.Surnamelbl.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "The default password is \'password\' for first time login.";
            // 
            // AddStaffbtn
            // 
            this.AddStaffbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.AddStaffbtn.Location = new System.Drawing.Point(23, 334);
            this.AddStaffbtn.Name = "AddStaffbtn";
            this.AddStaffbtn.Size = new System.Drawing.Size(213, 57);
            this.AddStaffbtn.TabIndex = 6;
            this.AddStaffbtn.Text = "SUBMIT";
            this.AddStaffbtn.UseVisualStyleBackColor = true;
            this.AddStaffbtn.Click += new System.EventHandler(this.AddStaffbtn_Click_1);
            // 
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstNamelbl.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.FirstNamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstNamelbl.Location = new System.Drawing.Point(20, 32);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(97, 18);
            this.FirstNamelbl.TabIndex = 30;
            this.FirstNamelbl.Text = "Forename:";
            // 
            // Username2lbl
            // 
            this.Username2lbl.AutoSize = true;
            this.Username2lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Username2lbl.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.Username2lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Username2lbl.Location = new System.Drawing.Point(20, 157);
            this.Username2lbl.Name = "Username2lbl";
            this.Username2lbl.Size = new System.Drawing.Size(98, 18);
            this.Username2lbl.TabIndex = 24;
            this.Username2lbl.Text = "Username:";
            // 
            // Forenametxt
            // 
            this.Forenametxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Forenametxt.Location = new System.Drawing.Point(23, 58);
            this.Forenametxt.Name = "Forenametxt";
            this.Forenametxt.Size = new System.Drawing.Size(178, 27);
            this.Forenametxt.TabIndex = 1;
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Usernametxt.Location = new System.Drawing.Point(23, 178);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(213, 27);
            this.Usernametxt.TabIndex = 3;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.Red;
            this.Usernamelbl.Location = new System.Drawing.Point(954, 654);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(0, 16);
            this.Usernamelbl.TabIndex = 42;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Logoutbtn.Location = new System.Drawing.Point(1066, 648);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 29);
            this.Logoutbtn.TabIndex = 43;
            this.Logoutbtn.Text = "LOGOUT";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click_1);
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Statuslbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Statuslbl.Location = new System.Drawing.Point(857, 654);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(97, 16);
            this.Statuslbl.TabIndex = 41;
            this.Statuslbl.Text = "Logged in as:";
            // 
            // ManageStaffAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.AddStaffgb);
            this.Controls.Add(this.CurrentStaffgb);
            this.Controls.Add(this.StaffAccountslbl);
            this.Controls.Add(this.Homebtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ManageStaffAccounts";
            this.Text = "Manage Staff Accounts";
            this.Load += new System.EventHandler(this.ManageAdminAccounts_Load);
            this.CurrentStaffgb.ResumeLayout(false);
            this.AddStaffgb.ResumeLayout(false);
            this.AddStaffgb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Label StaffAccountslbl;
        private System.Windows.Forms.GroupBox CurrentStaffgb;
        private System.Windows.Forms.ListBox Stafflb;
        private System.Windows.Forms.GroupBox AddStaffgb;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Button AddStaffbtn;
        private System.Windows.Forms.Label Username2lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Forenametxt;
        private System.Windows.Forms.Label FirstNamelbl;
        private System.Windows.Forms.Label Surnamelbl;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.ComboBox Rolecb;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label Statuslbl;
    }
}