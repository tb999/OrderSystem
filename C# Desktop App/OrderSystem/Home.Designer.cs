namespace OrderSystem
{
    partial class HomeForm
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
            this.Homelbl = new System.Windows.Forms.Label();
            this.ManageOrdersbtn = new System.Windows.Forms.Button();
            this.AddOrderbtn = new System.Windows.Forms.Button();
            this.ManageAccountsbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.ManageStockbtn = new System.Windows.Forms.Button();
            this.Ordersgb = new System.Windows.Forms.GroupBox();
            this.Accountsgb = new System.Windows.Forms.GroupBox();
            this.StaffAccountsbtn = new System.Windows.Forms.Button();
            this.viewstatsbtn = new System.Windows.Forms.Button();
            this.statsgb = new System.Windows.Forms.GroupBox();
            this.stockgb = new System.Windows.Forms.GroupBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.Ordersgb.SuspendLayout();
            this.Accountsgb.SuspendLayout();
            this.statsgb.SuspendLayout();
            this.stockgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Homelbl
            // 
            this.Homelbl.AutoSize = true;
            this.Homelbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Homelbl.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Homelbl.Location = new System.Drawing.Point(487, 29);
            this.Homelbl.Name = "Homelbl";
            this.Homelbl.Size = new System.Drawing.Size(210, 38);
            this.Homelbl.TabIndex = 0;
            this.Homelbl.Text = "Main Menu";
            // 
            // ManageOrdersbtn
            // 
            this.ManageOrdersbtn.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Bold);
            this.ManageOrdersbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManageOrdersbtn.Location = new System.Drawing.Point(211, 37);
            this.ManageOrdersbtn.Name = "ManageOrdersbtn";
            this.ManageOrdersbtn.Size = new System.Drawing.Size(162, 138);
            this.ManageOrdersbtn.TabIndex = 2;
            this.ManageOrdersbtn.Text = "Manage Orders";
            this.ManageOrdersbtn.UseVisualStyleBackColor = true;
            this.ManageOrdersbtn.Click += new System.EventHandler(this.ManageOrdersbtn_Click);
            // 
            // AddOrderbtn
            // 
            this.AddOrderbtn.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Bold);
            this.AddOrderbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddOrderbtn.Location = new System.Drawing.Point(17, 37);
            this.AddOrderbtn.Name = "AddOrderbtn";
            this.AddOrderbtn.Size = new System.Drawing.Size(162, 138);
            this.AddOrderbtn.TabIndex = 1;
            this.AddOrderbtn.Text = "Add Order";
            this.AddOrderbtn.UseVisualStyleBackColor = true;
            this.AddOrderbtn.Click += new System.EventHandler(this.AddOrderbtn_Click);
            // 
            // ManageAccountsbtn
            // 
            this.ManageAccountsbtn.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.ManageAccountsbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManageAccountsbtn.Location = new System.Drawing.Point(17, 41);
            this.ManageAccountsbtn.Name = "ManageAccountsbtn";
            this.ManageAccountsbtn.Size = new System.Drawing.Size(162, 138);
            this.ManageAccountsbtn.TabIndex = 4;
            this.ManageAccountsbtn.Text = "Manage Customer Accounts";
            this.ManageAccountsbtn.UseVisualStyleBackColor = true;
            this.ManageAccountsbtn.Click += new System.EventHandler(this.ManageAccountsbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(22, 623);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(127, 77);
            this.Exitbtn.TabIndex = 0;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageStockbtn
            // 
            this.ManageStockbtn.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Bold);
            this.ManageStockbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManageStockbtn.Location = new System.Drawing.Point(17, 40);
            this.ManageStockbtn.Name = "ManageStockbtn";
            this.ManageStockbtn.Size = new System.Drawing.Size(162, 138);
            this.ManageStockbtn.TabIndex = 3;
            this.ManageStockbtn.Text = "Manage Stock";
            this.ManageStockbtn.UseVisualStyleBackColor = true;
            this.ManageStockbtn.Click += new System.EventHandler(this.ManageStockbtn_Click);
            // 
            // Ordersgb
            // 
            this.Ordersgb.Controls.Add(this.ManageOrdersbtn);
            this.Ordersgb.Controls.Add(this.AddOrderbtn);
            this.Ordersgb.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Ordersgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ordersgb.Location = new System.Drawing.Point(169, 121);
            this.Ordersgb.Name = "Ordersgb";
            this.Ordersgb.Size = new System.Drawing.Size(395, 206);
            this.Ordersgb.TabIndex = 0;
            this.Ordersgb.TabStop = false;
            this.Ordersgb.Text = "Orders";
            // 
            // Accountsgb
            // 
            this.Accountsgb.Controls.Add(this.StaffAccountsbtn);
            this.Accountsgb.Controls.Add(this.ManageAccountsbtn);
            this.Accountsgb.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Accountsgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accountsgb.Location = new System.Drawing.Point(169, 351);
            this.Accountsgb.Name = "Accountsgb";
            this.Accountsgb.Size = new System.Drawing.Size(395, 206);
            this.Accountsgb.TabIndex = 0;
            this.Accountsgb.TabStop = false;
            this.Accountsgb.Text = "Account Administration";
            // 
            // StaffAccountsbtn
            // 
            this.StaffAccountsbtn.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.StaffAccountsbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StaffAccountsbtn.Location = new System.Drawing.Point(211, 41);
            this.StaffAccountsbtn.Name = "StaffAccountsbtn";
            this.StaffAccountsbtn.Size = new System.Drawing.Size(162, 138);
            this.StaffAccountsbtn.TabIndex = 5;
            this.StaffAccountsbtn.Text = "Manage Staff Accounts";
            this.StaffAccountsbtn.UseVisualStyleBackColor = true;
            this.StaffAccountsbtn.Click += new System.EventHandler(this.StaffAccountsbtn_Click);
            // 
            // viewstatsbtn
            // 
            this.viewstatsbtn.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.viewstatsbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewstatsbtn.Location = new System.Drawing.Point(17, 40);
            this.viewstatsbtn.Name = "viewstatsbtn";
            this.viewstatsbtn.Size = new System.Drawing.Size(162, 138);
            this.viewstatsbtn.TabIndex = 6;
            this.viewstatsbtn.Text = "View Stats";
            this.viewstatsbtn.UseVisualStyleBackColor = true;
            this.viewstatsbtn.Click += new System.EventHandler(this.viewstatsbtn_Click);
            // 
            // statsgb
            // 
            this.statsgb.Controls.Add(this.viewstatsbtn);
            this.statsgb.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.statsgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statsgb.Location = new System.Drawing.Point(604, 352);
            this.statsgb.Name = "statsgb";
            this.statsgb.Size = new System.Drawing.Size(395, 206);
            this.statsgb.TabIndex = 0;
            this.statsgb.TabStop = false;
            this.statsgb.Text = "Statistics";
            // 
            // stockgb
            // 
            this.stockgb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stockgb.Controls.Add(this.ManageStockbtn);
            this.stockgb.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.stockgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockgb.Location = new System.Drawing.Point(604, 121);
            this.stockgb.Name = "stockgb";
            this.stockgb.Size = new System.Drawing.Size(395, 206);
            this.stockgb.TabIndex = 0;
            this.stockgb.TabStop = false;
            this.stockgb.Text = "Stock Control";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.Red;
            this.Usernamelbl.Location = new System.Drawing.Point(954, 654);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(0, 16);
            this.Usernamelbl.TabIndex = 5;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Logoutbtn.Location = new System.Drawing.Point(1066, 648);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 29);
            this.Logoutbtn.TabIndex = 6;
            this.Logoutbtn.Text = "LOGOUT";
            this.Logoutbtn.UseVisualStyleBackColor = true;
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
            this.Statuslbl.TabIndex = 4;
            this.Statuslbl.Text = "Logged in as:";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.stockgb);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.statsgb);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.Accountsgb);
            this.Controls.Add(this.Ordersgb);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Homelbl);
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Ordersgb.ResumeLayout(false);
            this.Accountsgb.ResumeLayout(false);
            this.statsgb.ResumeLayout(false);
            this.stockgb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.Button ManageOrdersbtn;
        private System.Windows.Forms.Button AddOrderbtn;
        private System.Windows.Forms.Button ManageAccountsbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button ManageStockbtn;
        private System.Windows.Forms.GroupBox Ordersgb;
        private System.Windows.Forms.GroupBox Accountsgb;
        private System.Windows.Forms.Button StaffAccountsbtn;
        private System.Windows.Forms.Button viewstatsbtn;
        private System.Windows.Forms.GroupBox statsgb;
        private System.Windows.Forms.GroupBox stockgb;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label Statuslbl;

    }
}