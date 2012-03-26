namespace OrderSystem
{
    partial class ManageOrders
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
            this.Ordersdg = new System.Windows.Forms.DataGridView();
            this.CompletedOrdersrb = new System.Windows.Forms.RadioButton();
            this.AwaitingDeliveryrb = new System.Windows.Forms.RadioButton();
            this.OrderItemsdg = new System.Windows.Forms.DataGridView();
            this.SentItembtn = new System.Windows.Forms.Button();
            this.RemoveItembtn = new System.Windows.Forms.Button();
            this.ViewOrderItemsbtn = new System.Windows.Forms.Button();
            this.Ordersgb = new System.Windows.Forms.GroupBox();
            this.Itemsgb = new System.Windows.Forms.GroupBox();
            this.SentAllbtn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.ManageOrderlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ordersdg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsdg)).BeginInit();
            this.Ordersgb.SuspendLayout();
            this.Itemsgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ordersdg
            // 
            this.Ordersdg.AllowUserToAddRows = false;
            this.Ordersdg.AllowUserToDeleteRows = false;
            this.Ordersdg.AllowUserToOrderColumns = true;
            this.Ordersdg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Ordersdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ordersdg.Location = new System.Drawing.Point(22, 28);
            this.Ordersdg.MultiSelect = false;
            this.Ordersdg.Name = "Ordersdg";
            this.Ordersdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ordersdg.Size = new System.Drawing.Size(547, 150);
            this.Ordersdg.TabIndex = 0;
            // 
            // CompletedOrdersrb
            // 
            this.CompletedOrdersrb.AutoSize = true;
            this.CompletedOrdersrb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.CompletedOrdersrb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CompletedOrdersrb.Location = new System.Drawing.Point(619, 75);
            this.CompletedOrdersrb.Name = "CompletedOrdersrb";
            this.CompletedOrdersrb.Size = new System.Drawing.Size(154, 17);
            this.CompletedOrdersrb.TabIndex = 0;
            this.CompletedOrdersrb.TabStop = true;
            this.CompletedOrdersrb.Text = "COMPLETED ORDERS";
            this.CompletedOrdersrb.UseVisualStyleBackColor = true;
            this.CompletedOrdersrb.CheckedChanged += new System.EventHandler(this.CompletedOrdersrb_CheckedChanged);
            // 
            // AwaitingDeliveryrb
            // 
            this.AwaitingDeliveryrb.AutoSize = true;
            this.AwaitingDeliveryrb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.AwaitingDeliveryrb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AwaitingDeliveryrb.Location = new System.Drawing.Point(619, 43);
            this.AwaitingDeliveryrb.Name = "AwaitingDeliveryrb";
            this.AwaitingDeliveryrb.Size = new System.Drawing.Size(159, 17);
            this.AwaitingDeliveryrb.TabIndex = 0;
            this.AwaitingDeliveryrb.TabStop = true;
            this.AwaitingDeliveryrb.Text = "AWAITING DELIVERY";
            this.AwaitingDeliveryrb.UseVisualStyleBackColor = true;
            this.AwaitingDeliveryrb.CheckedChanged += new System.EventHandler(this.AwaitingDeliveryrb_CheckedChanged);
            // 
            // OrderItemsdg
            // 
            this.OrderItemsdg.AllowUserToAddRows = false;
            this.OrderItemsdg.AllowUserToDeleteRows = false;
            this.OrderItemsdg.AllowUserToOrderColumns = true;
            this.OrderItemsdg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.OrderItemsdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItemsdg.Location = new System.Drawing.Point(20, 29);
            this.OrderItemsdg.Name = "OrderItemsdg";
            this.OrderItemsdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderItemsdg.Size = new System.Drawing.Size(549, 150);
            this.OrderItemsdg.TabIndex = 3;
            // 
            // SentItembtn
            // 
            this.SentItembtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.SentItembtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SentItembtn.Location = new System.Drawing.Point(655, 29);
            this.SentItembtn.Name = "SentItembtn";
            this.SentItembtn.Size = new System.Drawing.Size(91, 37);
            this.SentItembtn.TabIndex = 0;
            this.SentItembtn.Text = "SENT";
            this.SentItembtn.UseVisualStyleBackColor = true;
            this.SentItembtn.Click += new System.EventHandler(this.SentItembtn_Click);
            // 
            // RemoveItembtn
            // 
            this.RemoveItembtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.RemoveItembtn.ForeColor = System.Drawing.Color.DarkRed;
            this.RemoveItembtn.Location = new System.Drawing.Point(655, 142);
            this.RemoveItembtn.Name = "RemoveItembtn";
            this.RemoveItembtn.Size = new System.Drawing.Size(91, 37);
            this.RemoveItembtn.TabIndex = 0;
            this.RemoveItembtn.Text = "REMOVE ITEM";
            this.RemoveItembtn.UseVisualStyleBackColor = true;
            this.RemoveItembtn.Click += new System.EventHandler(this.RemoveItembtn_Click);
            // 
            // ViewOrderItemsbtn
            // 
            this.ViewOrderItemsbtn.Enabled = false;
            this.ViewOrderItemsbtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.ViewOrderItemsbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewOrderItemsbtn.Location = new System.Drawing.Point(619, 111);
            this.ViewOrderItemsbtn.Name = "ViewOrderItemsbtn";
            this.ViewOrderItemsbtn.Size = new System.Drawing.Size(154, 67);
            this.ViewOrderItemsbtn.TabIndex = 1;
            this.ViewOrderItemsbtn.Text = "VIEW ORDER ITEMS";
            this.ViewOrderItemsbtn.UseVisualStyleBackColor = true;
            this.ViewOrderItemsbtn.Click += new System.EventHandler(this.ViewOrderItemsbtn_Click);
            // 
            // Ordersgb
            // 
            this.Ordersgb.Controls.Add(this.ViewOrderItemsbtn);
            this.Ordersgb.Controls.Add(this.Ordersdg);
            this.Ordersgb.Controls.Add(this.AwaitingDeliveryrb);
            this.Ordersgb.Controls.Add(this.CompletedOrdersrb);
            this.Ordersgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ordersgb.Location = new System.Drawing.Point(175, 111);
            this.Ordersgb.Name = "Ordersgb";
            this.Ordersgb.Size = new System.Drawing.Size(822, 199);
            this.Ordersgb.TabIndex = 8;
            this.Ordersgb.TabStop = false;
            this.Ordersgb.Text = "Orders";
            // 
            // Itemsgb
            // 
            this.Itemsgb.Controls.Add(this.SentAllbtn);
            this.Itemsgb.Controls.Add(this.OrderItemsdg);
            this.Itemsgb.Controls.Add(this.SentItembtn);
            this.Itemsgb.Controls.Add(this.RemoveItembtn);
            this.Itemsgb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Itemsgb.Location = new System.Drawing.Point(175, 329);
            this.Itemsgb.Name = "Itemsgb";
            this.Itemsgb.Size = new System.Drawing.Size(822, 198);
            this.Itemsgb.TabIndex = 9;
            this.Itemsgb.TabStop = false;
            this.Itemsgb.Text = "Order Products";
            // 
            // SentAllbtn
            // 
            this.SentAllbtn.Enabled = false;
            this.SentAllbtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.SentAllbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SentAllbtn.Location = new System.Drawing.Point(655, 87);
            this.SentAllbtn.Name = "SentAllbtn";
            this.SentAllbtn.Size = new System.Drawing.Size(91, 37);
            this.SentAllbtn.TabIndex = 0;
            this.SentAllbtn.Text = "SENT ALL";
            this.SentAllbtn.UseVisualStyleBackColor = true;
            this.SentAllbtn.Click += new System.EventHandler(this.SentAllbtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.Homebtn.Location = new System.Drawing.Point(22, 623);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(127, 77);
            this.Homebtn.TabIndex = 10;
            this.Homebtn.Text = "HOME";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.Red;
            this.Usernamelbl.Location = new System.Drawing.Point(954, 654);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(0, 16);
            this.Usernamelbl.TabIndex = 45;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Logoutbtn.Location = new System.Drawing.Point(1066, 648);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 29);
            this.Logoutbtn.TabIndex = 46;
            this.Logoutbtn.Text = "LOGOUT";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
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
            this.Statuslbl.TabIndex = 44;
            this.Statuslbl.Text = "Logged in as:";
            // 
            // ManageOrderlbl
            // 
            this.ManageOrderlbl.AutoSize = true;
            this.ManageOrderlbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ManageOrderlbl.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageOrderlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManageOrderlbl.Location = new System.Drawing.Point(439, 41);
            this.ManageOrderlbl.Name = "ManageOrderlbl";
            this.ManageOrderlbl.Size = new System.Drawing.Size(287, 38);
            this.ManageOrderlbl.TabIndex = 2;
            this.ManageOrderlbl.Text = "Manage Orders";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.ManageOrderlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Itemsgb);
            this.Controls.Add(this.Ordersgb);
            this.Name = "ManageOrders";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ordersdg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsdg)).EndInit();
            this.Ordersgb.ResumeLayout(false);
            this.Ordersgb.PerformLayout();
            this.Itemsgb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ordersdg;
        private System.Windows.Forms.RadioButton CompletedOrdersrb;
        private System.Windows.Forms.RadioButton AwaitingDeliveryrb;
        private System.Windows.Forms.DataGridView OrderItemsdg;
        private System.Windows.Forms.Button SentItembtn;
        private System.Windows.Forms.Button RemoveItembtn;
        private System.Windows.Forms.Button ViewOrderItemsbtn;
        private System.Windows.Forms.GroupBox Ordersgb;
        private System.Windows.Forms.GroupBox Itemsgb;
        private System.Windows.Forms.Button SentAllbtn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Label ManageOrderlbl;
    }
}