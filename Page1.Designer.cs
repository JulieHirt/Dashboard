namespace Wisej.DxDashboardSample
{
    partial class Page1
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dxDashboard1 = new Wisej.Web.Ext.DxDashboard.DxDashboard();
			this.buttonWorkingMode = new Wisej.Web.Button();
			this.label1 = new Wisej.Web.Label();
			this.panel1 = new Wisej.Web.Panel();
			this.splitButton1 = new Wisej.Web.SplitButton();
			this.CustomerReports = new Wisej.Web.MenuItem();
			this.Customers = new Wisej.Web.MenuItem();
			this.EmployeeCustomers = new Wisej.Web.MenuItem();
			this.OrderDetails = new Wisej.Web.MenuItem();
			this.ProductReports = new Wisej.Web.MenuItem();
			this.OrderReports = new Wisej.Web.MenuItem();
			this.listBox1 = new Wisej.Web.ListBox();
			this.button1 = new Wisej.Web.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dxDashboard1
			// 
			this.dxDashboard1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxDashboard1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.dxDashboard1.Location = new System.Drawing.Point(410, 144);
			this.dxDashboard1.Name = "dxDashboard1";
			this.dxDashboard1.Size = new System.Drawing.Size(696, 310);
			this.dxDashboard1.TabIndex = 0;
			this.dxDashboard1.Text = "dxDashboard1";
			this.dxDashboard1.WebRequest += new Wisej.Web.WebRequestHandler(this.dxDashboard1_WebRequest);
			// 
			// buttonWorkingMode
			// 
			this.buttonWorkingMode.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonWorkingMode.Location = new System.Drawing.Point(58, 244);
			this.buttonWorkingMode.Name = "buttonWorkingMode";
			this.buttonWorkingMode.Size = new System.Drawing.Size(156, 37);
			this.buttonWorkingMode.TabIndex = 1;
			this.buttonWorkingMode.Text = "Toggle Working Mode";
			this.buttonWorkingMode.Click += new System.EventHandler(this.buttonWorkingMode_Click);
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(210, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(569, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Restore /Data/nwind.mdb to a SQL database and update the connection string in app" +
    "settings.json.";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.Controls.Add(this.splitButton1);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Location = new System.Drawing.Point(238, 144);
			this.panel1.Name = "panel1";
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(172, 310);
			this.panel1.TabIndex = 3;
			this.panel1.Text = "DASHBOARDS";
			// 
			// splitButton1
			// 
			this.splitButton1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.splitButton1.Location = new System.Drawing.Point(-1, 234);
			this.splitButton1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.CustomerReports,
            this.Customers,
            this.EmployeeCustomers,
            this.OrderDetails,
            this.ProductReports,
            this.OrderReports});
			this.splitButton1.Name = "splitButton1";
			this.splitButton1.Orientation = Wisej.Web.Orientation.Vertical;
			this.splitButton1.Size = new System.Drawing.Size(172, 47);
			this.splitButton1.TabIndex = 2;
			this.splitButton1.Text = "Add New Dashboard";
			this.splitButton1.Click += new System.EventHandler(this.splitButton1_Click);
			// 
			// CustomerReports
			// 
			this.CustomerReports.Index = 0;
			this.CustomerReports.Name = "CustomerReports";
			this.CustomerReports.Text = "CustomerReports";
			// 
			// Customers
			// 
			this.Customers.Index = 1;
			this.Customers.Name = "Customers";
			this.Customers.Text = "Customers";
			// 
			// EmployeeCustomers
			// 
			this.EmployeeCustomers.Index = 2;
			this.EmployeeCustomers.Name = "EmployeeCustomers";
			this.EmployeeCustomers.Text = "EmployeeCustomers";
			// 
			// OrderDetails
			// 
			this.OrderDetails.Index = 3;
			this.OrderDetails.Name = "OrderDetails";
			this.OrderDetails.Text = "OrderDetails";
			// 
			// ProductReports
			// 
			this.ProductReports.Index = 4;
			this.ProductReports.Name = "ProductReports";
			this.ProductReports.Text = "ProductReports";
			// 
			// OrderReports
			// 
			this.OrderReports.Index = 5;
			this.OrderReports.Name = "OrderReports";
			this.OrderReports.Text = "OrderReports";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.listBox1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.listBox1.Items.AddRange(new object[] {
            "one ",
            "two ",
            "three"});
			this.listBox1.Location = new System.Drawing.Point(-1, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(172, 235);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(867, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 49);
			this.button1.TabIndex = 4;
			this.button1.Text = "save changes to dashboard";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonWorkingMode);
			this.Controls.Add(this.dxDashboard1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1173, 502);
			this.Load += new System.EventHandler(this.Page1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.Ext.DxDashboard.DxDashboard dxDashboard1;
        private Web.Button buttonWorkingMode;
		private Web.Label label1;
		private Web.Panel panel1;
		private Web.ListBox listBox1;
		private Web.SplitButton splitButton1;
		private Web.MenuItem CustomerReports;
		private Web.MenuItem Customers;
		private Web.MenuItem EmployeeCustomers;
		private Web.MenuItem OrderDetails;
		private Web.MenuItem ProductReports;
		private Web.MenuItem OrderReports;
		private Web.Button button1;
	}
}

