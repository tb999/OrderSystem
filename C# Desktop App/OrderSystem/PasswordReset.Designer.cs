namespace OrderSystem
{
    partial class PasswordReset
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
            this.label1 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.EmailAddresslbl = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Answer2lbl = new System.Windows.Forms.Label();
            this.Answer1lbl = new System.Windows.Forms.Label();
            this.Answer2txt = new System.Windows.Forms.TextBox();
            this.Answer1txt = new System.Windows.Forms.TextBox();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Statusgb = new System.Windows.Forms.GroupBox();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.Statusgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(271, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.Exitbtn.Location = new System.Drawing.Point(12, 484);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(100, 44);
            this.Exitbtn.TabIndex = 0;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailAddresslbl
            // 
            this.EmailAddresslbl.AutoSize = true;
            this.EmailAddresslbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmailAddresslbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddresslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailAddresslbl.Location = new System.Drawing.Point(301, 106);
            this.EmailAddresslbl.Name = "EmailAddresslbl";
            this.EmailAddresslbl.Size = new System.Drawing.Size(87, 16);
            this.EmailAddresslbl.TabIndex = 0;
            this.EmailAddresslbl.Text = "Username:";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(304, 136);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(234, 40);
            this.Usernametxt.TabIndex = 1;
            this.Usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Answer2lbl
            // 
            this.Answer2lbl.AutoSize = true;
            this.Answer2lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Answer2lbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Answer2lbl.Location = new System.Drawing.Point(301, 281);
            this.Answer2lbl.Name = "Answer2lbl";
            this.Answer2lbl.Size = new System.Drawing.Size(218, 16);
            this.Answer2lbl.TabIndex = 0;
            this.Answer2lbl.Text = "Favorite Musical Instrument:";
            // 
            // Answer1lbl
            // 
            this.Answer1lbl.AutoSize = true;
            this.Answer1lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Answer1lbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Answer1lbl.Location = new System.Drawing.Point(301, 194);
            this.Answer1lbl.Name = "Answer1lbl";
            this.Answer1lbl.Size = new System.Drawing.Size(174, 16);
            this.Answer1lbl.TabIndex = 0;
            this.Answer1lbl.Text = "Mothers Maiden Name:";
            // 
            // Answer2txt
            // 
            this.Answer2txt.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2txt.Location = new System.Drawing.Point(304, 306);
            this.Answer2txt.Name = "Answer2txt";
            this.Answer2txt.PasswordChar = '*';
            this.Answer2txt.Size = new System.Drawing.Size(234, 40);
            this.Answer2txt.TabIndex = 3;
            this.Answer2txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Answer1txt
            // 
            this.Answer1txt.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1txt.Location = new System.Drawing.Point(304, 224);
            this.Answer1txt.Name = "Answer1txt";
            this.Answer1txt.PasswordChar = '*';
            this.Answer1txt.Size = new System.Drawing.Size(234, 40);
            this.Answer1txt.TabIndex = 2;
            this.Answer1txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Resetbtn
            // 
            this.Resetbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.Resetbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.Resetbtn.Location = new System.Drawing.Point(315, 365);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(102, 44);
            this.Resetbtn.TabIndex = 4;
            this.Resetbtn.Text = "Reset Password";
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cancelbtn.Location = new System.Drawing.Point(423, 365);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(102, 44);
            this.Cancelbtn.TabIndex = 5;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Statusgb
            // 
            this.Statusgb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Statusgb.Controls.Add(this.Statuslbl);
            this.Statusgb.Location = new System.Drawing.Point(567, 499);
            this.Statusgb.Name = "Statusgb";
            this.Statusgb.Size = new System.Drawing.Size(287, 29);
            this.Statusgb.TabIndex = 0;
            this.Statusgb.TabStop = false;
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Statuslbl.Font = new System.Drawing.Font("Verdana", 8F);
            this.Statuslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Statuslbl.Location = new System.Drawing.Point(48, 10);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(188, 13);
            this.Statuslbl.TabIndex = 0;
            this.Statuslbl.Text = "You are currently not logged in.";
            // 
            // PasswordReset
            // 
            this.AcceptButton = this.Resetbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.Statusgb);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Answer2lbl);
            this.Controls.Add(this.Answer1lbl);
            this.Controls.Add(this.Answer2txt);
            this.Controls.Add(this.Answer1txt);
            this.Controls.Add(this.EmailAddresslbl);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.label1);
            this.Name = "PasswordReset";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.PasswordReset_Load);
            this.Statusgb.ResumeLayout(false);
            this.Statusgb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label EmailAddresslbl;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label Answer2lbl;
        private System.Windows.Forms.Label Answer1lbl;
        private System.Windows.Forms.TextBox Answer2txt;
        private System.Windows.Forms.TextBox Answer1txt;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.GroupBox Statusgb;
        private System.Windows.Forms.Label Statuslbl;
    }
}