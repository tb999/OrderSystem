namespace OrderSystem
{
    partial class AddOrder
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
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.Recordnolbl = new System.Windows.Forms.Label();
            this.Addgb = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.AddOrderlbl = new System.Windows.Forms.Label();
            this.Customergb = new System.Windows.Forms.GroupBox();
            this.SearchPanel2 = new System.Windows.Forms.Panel();
            this.SearchCustomersgb = new System.Windows.Forms.GroupBox();
            this.CustomerIDrb = new System.Windows.Forms.RadioButton();
            this.Emailrb = new System.Windows.Forms.RadioButton();
            this.SearchCustomersbtn = new System.Windows.Forms.Button();
            this.SearchCustomerstxt = new System.Windows.Forms.TextBox();
            this.ShowAllCustomersbtn = new System.Windows.Forms.Button();
            this.Customersdg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchPanel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Searchgb = new System.Windows.Forms.GroupBox();
            this.ProductIDrb = new System.Windows.Forms.RadioButton();
            this.ProductNamerb = new System.Windows.Forms.RadioButton();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.ProductSearchtxt = new System.Windows.Forms.TextBox();
            this.ShowAllbtn = new System.Windows.Forms.Button();
            this.Productsdg = new System.Windows.Forms.DataGridView();
            this.Addgb.SuspendLayout();
            this.Customergb.SuspendLayout();
            this.SearchPanel2.SuspendLayout();
            this.SearchCustomersgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customersdg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Searchgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productsdg)).BeginInit();
            this.SuspendLayout();
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Logoutbtn.Location = new System.Drawing.Point(1066, 648);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 29);
            this.Logoutbtn.TabIndex = 2;
            this.Logoutbtn.Text = "LOGOUT";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.Red;
            this.Usernamelbl.Location = new System.Drawing.Point(954, 654);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(0, 16);
            this.Usernamelbl.TabIndex = 1;
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
            this.Statuslbl.TabIndex = 0;
            this.Statuslbl.Text = "Logged in as:";
            // 
            // Recordnolbl
            // 
            this.Recordnolbl.AutoSize = true;
            this.Recordnolbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Recordnolbl.Location = new System.Drawing.Point(139, 684);
            this.Recordnolbl.Name = "Recordnolbl";
            this.Recordnolbl.Size = new System.Drawing.Size(0, 13);
            this.Recordnolbl.TabIndex = 15;
            // 
            // Addgb
            // 
            this.Addgb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Addgb.Controls.Add(this.button1);
            this.Addgb.Controls.Add(this.Addbtn);
            this.Addgb.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addgb.Location = new System.Drawing.Point(428, 552);
            this.Addgb.Name = "Addgb";
            this.Addgb.Size = new System.Drawing.Size(351, 103);
            this.Addgb.TabIndex = 37;
            this.Addgb.TabStop = false;
            this.Addgb.Text = "Create Order";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(187, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "COMPLETE ORDER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Addbtn.Location = new System.Drawing.Point(6, 31);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(155, 53);
            this.Addbtn.TabIndex = 12;
            this.Addbtn.Text = "ADD TO ORDER";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.Homebtn.Location = new System.Drawing.Point(22, 623);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(127, 77);
            this.Homebtn.TabIndex = 36;
            this.Homebtn.Text = "HOME";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // AddOrderlbl
            // 
            this.AddOrderlbl.AutoSize = true;
            this.AddOrderlbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddOrderlbl.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddOrderlbl.Location = new System.Drawing.Point(486, 39);
            this.AddOrderlbl.Name = "AddOrderlbl";
            this.AddOrderlbl.Size = new System.Drawing.Size(199, 38);
            this.AddOrderlbl.TabIndex = 35;
            this.AddOrderlbl.Text = "Add Order";
            // 
            // Customergb
            // 
            this.Customergb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Customergb.Controls.Add(this.SearchPanel2);
            this.Customergb.Controls.Add(this.ShowAllCustomersbtn);
            this.Customergb.Controls.Add(this.Customersdg);
            this.Customergb.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Customergb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Customergb.Location = new System.Drawing.Point(615, 109);
            this.Customergb.Name = "Customergb";
            this.Customergb.Size = new System.Drawing.Size(546, 425);
            this.Customergb.TabIndex = 38;
            this.Customergb.TabStop = false;
            this.Customergb.Text = "Customers";
            // 
            // SearchPanel2
            // 
            this.SearchPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel2.Controls.Add(this.SearchCustomersgb);
            this.SearchPanel2.Location = new System.Drawing.Point(33, 293);
            this.SearchPanel2.Name = "SearchPanel2";
            this.SearchPanel2.Size = new System.Drawing.Size(306, 100);
            this.SearchPanel2.TabIndex = 50;
            // 
            // SearchCustomersgb
            // 
            this.SearchCustomersgb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchCustomersgb.Controls.Add(this.CustomerIDrb);
            this.SearchCustomersgb.Controls.Add(this.Emailrb);
            this.SearchCustomersgb.Controls.Add(this.SearchCustomersbtn);
            this.SearchCustomersgb.Controls.Add(this.SearchCustomerstxt);
            this.SearchCustomersgb.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.SearchCustomersgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchCustomersgb.Location = new System.Drawing.Point(10, 10);
            this.SearchCustomersgb.Name = "SearchCustomersgb";
            this.SearchCustomersgb.Size = new System.Drawing.Size(293, 87);
            this.SearchCustomersgb.TabIndex = 36;
            this.SearchCustomersgb.TabStop = false;
            this.SearchCustomersgb.Text = "Search Customers";
            // 
            // CustomerIDrb
            // 
            this.CustomerIDrb.AutoSize = true;
            this.CustomerIDrb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDrb.Location = new System.Drawing.Point(17, 19);
            this.CustomerIDrb.Name = "CustomerIDrb";
            this.CustomerIDrb.Size = new System.Drawing.Size(112, 17);
            this.CustomerIDrb.TabIndex = 35;
            this.CustomerIDrb.TabStop = true;
            this.CustomerIDrb.Text = "CUSTOMER ID";
            this.CustomerIDrb.UseVisualStyleBackColor = true;
            // 
            // Emailrb
            // 
            this.Emailrb.AutoSize = true;
            this.Emailrb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailrb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Emailrb.Location = new System.Drawing.Point(138, 19);
            this.Emailrb.Name = "Emailrb";
            this.Emailrb.Size = new System.Drawing.Size(65, 17);
            this.Emailrb.TabIndex = 34;
            this.Emailrb.TabStop = true;
            this.Emailrb.Text = "EMAIL";
            this.Emailrb.UseVisualStyleBackColor = true;
            // 
            // SearchCustomersbtn
            // 
            this.SearchCustomersbtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomersbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchCustomersbtn.Location = new System.Drawing.Point(201, 46);
            this.SearchCustomersbtn.Name = "SearchCustomersbtn";
            this.SearchCustomersbtn.Size = new System.Drawing.Size(77, 28);
            this.SearchCustomersbtn.TabIndex = 2;
            this.SearchCustomersbtn.Text = "SEARCH";
            this.SearchCustomersbtn.UseVisualStyleBackColor = true;
            this.SearchCustomersbtn.Click += new System.EventHandler(this.SearchCustomersbtn_Click);
            // 
            // SearchCustomerstxt
            // 
            this.SearchCustomerstxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerstxt.Location = new System.Drawing.Point(15, 50);
            this.SearchCustomerstxt.MaxLength = 50;
            this.SearchCustomerstxt.Name = "SearchCustomerstxt";
            this.SearchCustomerstxt.Size = new System.Drawing.Size(163, 21);
            this.SearchCustomerstxt.TabIndex = 0;
            // 
            // ShowAllCustomersbtn
            // 
            this.ShowAllCustomersbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAllCustomersbtn.Location = new System.Drawing.Point(399, 282);
            this.ShowAllCustomersbtn.Name = "ShowAllCustomersbtn";
            this.ShowAllCustomersbtn.Size = new System.Drawing.Size(115, 51);
            this.ShowAllCustomersbtn.TabIndex = 33;
            this.ShowAllCustomersbtn.Text = "SHOW ALL";
            this.ShowAllCustomersbtn.UseVisualStyleBackColor = true;
            this.ShowAllCustomersbtn.Click += new System.EventHandler(this.ShowAllCustomersbtn_Click);
            // 
            // Customersdg
            // 
            this.Customersdg.AllowUserToAddRows = false;
            this.Customersdg.AllowUserToDeleteRows = false;
            this.Customersdg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Customersdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customersdg.Location = new System.Drawing.Point(35, 32);
            this.Customersdg.Name = "Customersdg";
            this.Customersdg.ReadOnly = true;
            this.Customersdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Customersdg.Size = new System.Drawing.Size(479, 244);
            this.Customersdg.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ShowAllbtn);
            this.groupBox1.Controls.Add(this.Productsdg);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(22, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 425);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SearchPanel1);
            this.panel1.Controls.Add(this.Searchgb);
            this.panel1.Location = new System.Drawing.Point(45, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 100);
            this.panel1.TabIndex = 50;
            // 
            // SearchPanel1
            // 
            this.SearchPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel1.Controls.Add(this.groupBox2);
            this.SearchPanel1.Location = new System.Drawing.Point(-1, -1);
            this.SearchPanel1.Name = "SearchPanel1";
            this.SearchPanel1.Size = new System.Drawing.Size(306, 100);
            this.SearchPanel1.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(3, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 87);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Products";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(17, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 17);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PRODUCT ID";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(138, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NAME";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(203, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 50);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 21);
            this.textBox1.TabIndex = 0;
            // 
            // Searchgb
            // 
            this.Searchgb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Searchgb.Controls.Add(this.ProductIDrb);
            this.Searchgb.Controls.Add(this.ProductNamerb);
            this.Searchgb.Controls.Add(this.Searchbtn);
            this.Searchgb.Controls.Add(this.ProductSearchtxt);
            this.Searchgb.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Searchgb.Location = new System.Drawing.Point(3, 10);
            this.Searchgb.Name = "Searchgb";
            this.Searchgb.Size = new System.Drawing.Size(296, 87);
            this.Searchgb.TabIndex = 31;
            this.Searchgb.TabStop = false;
            this.Searchgb.Text = "Search Products";
            // 
            // ProductIDrb
            // 
            this.ProductIDrb.AutoSize = true;
            this.ProductIDrb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductIDrb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDrb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductIDrb.Location = new System.Drawing.Point(17, 19);
            this.ProductIDrb.Name = "ProductIDrb";
            this.ProductIDrb.Size = new System.Drawing.Size(94, 17);
            this.ProductIDrb.TabIndex = 35;
            this.ProductIDrb.TabStop = true;
            this.ProductIDrb.Text = "Product ID";
            this.ProductIDrb.UseVisualStyleBackColor = false;
            // 
            // ProductNamerb
            // 
            this.ProductNamerb.AutoSize = true;
            this.ProductNamerb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductNamerb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamerb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductNamerb.Location = new System.Drawing.Point(138, 19);
            this.ProductNamerb.Name = "ProductNamerb";
            this.ProductNamerb.Size = new System.Drawing.Size(62, 17);
            this.ProductNamerb.TabIndex = 34;
            this.ProductNamerb.TabStop = true;
            this.ProductNamerb.Text = "Name";
            this.ProductNamerb.UseVisualStyleBackColor = false;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Searchbtn.Location = new System.Drawing.Point(203, 46);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(77, 28);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "SEARCH";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // ProductSearchtxt
            // 
            this.ProductSearchtxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchtxt.Location = new System.Drawing.Point(15, 50);
            this.ProductSearchtxt.MaxLength = 50;
            this.ProductSearchtxt.Name = "ProductSearchtxt";
            this.ProductSearchtxt.Size = new System.Drawing.Size(163, 21);
            this.ProductSearchtxt.TabIndex = 0;
            // 
            // ShowAllbtn
            // 
            this.ShowAllbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAllbtn.Location = new System.Drawing.Point(423, 282);
            this.ShowAllbtn.Name = "ShowAllbtn";
            this.ShowAllbtn.Size = new System.Drawing.Size(115, 51);
            this.ShowAllbtn.TabIndex = 32;
            this.ShowAllbtn.Text = "SHOW ALL";
            this.ShowAllbtn.UseVisualStyleBackColor = true;
            this.ShowAllbtn.Click += new System.EventHandler(this.ShowAllbtn_Click);
            // 
            // Productsdg
            // 
            this.Productsdg.AllowUserToAddRows = false;
            this.Productsdg.AllowUserToDeleteRows = false;
            this.Productsdg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Productsdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productsdg.Location = new System.Drawing.Point(34, 32);
            this.Productsdg.Name = "Productsdg";
            this.Productsdg.ReadOnly = true;
            this.Productsdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productsdg.Size = new System.Drawing.Size(503, 244);
            this.Productsdg.TabIndex = 0;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Customergb);
            this.Controls.Add(this.Recordnolbl);
            this.Controls.Add(this.Addgb);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.AddOrderlbl);
            this.Name = "AddOrder";
            this.Text = "Add Order";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.Addgb.ResumeLayout(false);
            this.Customergb.ResumeLayout(false);
            this.SearchPanel2.ResumeLayout(false);
            this.SearchCustomersgb.ResumeLayout(false);
            this.SearchCustomersgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customersdg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SearchPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Searchgb.ResumeLayout(false);
            this.Searchgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productsdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Label Recordnolbl;
        private System.Windows.Forms.GroupBox Addgb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Label AddOrderlbl;
        private System.Windows.Forms.GroupBox Customergb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Productsdg;
        private System.Windows.Forms.GroupBox Searchgb;
        private System.Windows.Forms.RadioButton ProductIDrb;
        private System.Windows.Forms.RadioButton ProductNamerb;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox ProductSearchtxt;
        private System.Windows.Forms.Button ShowAllbtn;
        private System.Windows.Forms.DataGridView Customersdg;
        private System.Windows.Forms.GroupBox SearchCustomersgb;
        private System.Windows.Forms.RadioButton CustomerIDrb;
        private System.Windows.Forms.RadioButton Emailrb;
        private System.Windows.Forms.Button SearchCustomersbtn;
        private System.Windows.Forms.TextBox SearchCustomerstxt;
        private System.Windows.Forms.Button ShowAllCustomersbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SearchPanel2;
        private System.Windows.Forms.Panel SearchPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}