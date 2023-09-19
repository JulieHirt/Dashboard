namespace Wisej.DxDashboardSample
{
    partial class MainPage
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
			this.components = new System.ComponentModel.Container();
			this.dxDashboard1 = new Wisej.Web.Ext.DxDashboard.DxDashboard();
			this.buttonWorkingMode = new Wisej.Web.Button();
			this.panelDashboards = new Wisej.Web.Panel();
			this.listBox1 = new Wisej.Web.ListBox();
			this.buttonAddDashboard = new Wisej.Web.Button();
			this.flexLayoutPanelTools = new Wisej.Web.FlexLayoutPanel();
			this.buttonExportReport = new Wisej.Web.Button();
			this.buttonShare = new Wisej.Web.Button();
			this.buttonDelete = new Wisej.Web.Button();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.panel2 = new Wisej.Web.Panel();
			this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
			this.radioButton4 = new Wisej.Web.RadioButton();
			this.radioButton1 = new Wisej.Web.RadioButton();
			this.radioButton2 = new Wisej.Web.RadioButton();
			this.radioButton3 = new Wisej.Web.RadioButton();
			this.radioButton6 = new Wisej.Web.RadioButton();
			this.dateTimePicker4 = new Wisej.Web.DateTimePicker();
			this.dateTimePicker3 = new Wisej.Web.DateTimePicker();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.radioButton5 = new Wisej.Web.RadioButton();
			this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
			this.dateTimePicker2 = new Wisej.Web.DateTimePicker();
			this.label2 = new Wisej.Web.Label();
			this.contextMenuDashboards = new Wisej.Web.ContextMenu(this.components);
			this.panelDashboards.SuspendLayout();
			this.flexLayoutPanelTools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.flexLayoutPanel2.SuspendLayout();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dxDashboard1
			// 
			this.dxDashboard1.Dock = Wisej.Web.DockStyle.Fill;
			this.dxDashboard1.Location = new System.Drawing.Point(278, 103);
			this.dxDashboard1.Name = "dxDashboard1";
			this.dxDashboard1.Size = new System.Drawing.Size(920, 262);
			this.dxDashboard1.TabIndex = 0;
			this.dxDashboard1.Text = "dxDashboard1";
			this.dxDashboard1.WebRequest += new Wisej.Web.WebRequestHandler(this.dxDashboard1_WebRequest);
			// 
			// buttonWorkingMode
			// 
			this.buttonWorkingMode.Anchor = Wisej.Web.AnchorStyles.Top;
			this.buttonWorkingMode.BackColor = System.Drawing.Color.Transparent;
			this.buttonWorkingMode.Focusable = false;
			this.buttonWorkingMode.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			this.buttonWorkingMode.Location = new System.Drawing.Point(3, 11);
			this.buttonWorkingMode.Name = "buttonWorkingMode";
			this.buttonWorkingMode.Size = new System.Drawing.Size(44, 30);
			this.buttonWorkingMode.TabIndex = 1;
			this.buttonWorkingMode.Click += new System.EventHandler(this.buttonWorkingMode_Click);
			// 
			// panelDashboards
			// 
			this.panelDashboards.Controls.Add(this.listBox1);
			this.panelDashboards.Controls.Add(this.buttonAddDashboard);
			this.panelDashboards.CssStyle = "border: 1px solid blue;";
			this.panelDashboards.Dock = Wisej.Web.DockStyle.Left;
			this.panelDashboards.HeaderBackColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.panelDashboards.HeaderForeColor = System.Drawing.Color.Black;
			this.panelDashboards.Location = new System.Drawing.Point(50, 103);
			this.panelDashboards.Name = "panelDashboards";
			this.panelDashboards.ShowCloseButton = false;
			this.panelDashboards.ShowHeader = true;
			this.panelDashboards.Size = new System.Drawing.Size(228, 262);
			this.panelDashboards.TabIndex = 3;
			this.panelDashboards.Text = "MY DASHBOARDS";
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.listBox1.CssStyle = "border-radius: 0px;";
			this.listBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.listBox1.Focusable = false;
			this.listBox1.ItemHeight = 40;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(228, 166);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBoxDashboards_SelectedIndexChanged);
			// 
			// buttonAddDashboard
			// 
			this.buttonAddDashboard.BackColor = System.Drawing.Color.FromName("@primary");
			this.buttonAddDashboard.CssStyle = "border-radius: 0px;";
			this.buttonAddDashboard.Dock = Wisej.Web.DockStyle.Bottom;
			this.buttonAddDashboard.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
			this.buttonAddDashboard.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/bar-chart.svg";
			this.buttonAddDashboard.Location = new System.Drawing.Point(0, 166);
			this.buttonAddDashboard.Name = "buttonAddDashboard";
			this.buttonAddDashboard.Size = new System.Drawing.Size(228, 68);
			this.buttonAddDashboard.TabIndex = 1;
			this.buttonAddDashboard.Text = "Add Dashboard";
			this.buttonAddDashboard.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
			this.buttonAddDashboard.Click += new System.EventHandler(this.buttonAddDashboard_Click);
			// 
			// flexLayoutPanelTools
			// 
			this.flexLayoutPanelTools.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.flexLayoutPanelTools.Controls.Add(this.buttonWorkingMode);
			this.flexLayoutPanelTools.Controls.Add(this.buttonExportReport);
			this.flexLayoutPanelTools.Controls.Add(this.buttonShare);
			this.flexLayoutPanelTools.Controls.Add(this.buttonDelete);
			this.flexLayoutPanelTools.CssStyle = "border-radius: 0px;\r\nborder-right: 1px solid lightgray;";
			this.flexLayoutPanelTools.Dock = Wisej.Web.DockStyle.Left;
			this.flexLayoutPanelTools.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanelTools.Location = new System.Drawing.Point(0, 103);
			this.flexLayoutPanelTools.Name = "flexLayoutPanelTools";
			this.flexLayoutPanelTools.Padding = new Wisej.Web.Padding(0, 8, 0, 0);
			this.flexLayoutPanelTools.Size = new System.Drawing.Size(50, 262);
			this.flexLayoutPanelTools.TabIndex = 4;
			// 
			// buttonExportReport
			// 
			this.buttonExportReport.Anchor = Wisej.Web.AnchorStyles.Top;
			this.buttonExportReport.BackColor = System.Drawing.Color.Transparent;
			this.buttonExportReport.Focusable = false;
			this.buttonExportReport.ImageSource = "file-excel";
			this.buttonExportReport.Location = new System.Drawing.Point(3, 57);
			this.buttonExportReport.Name = "buttonExportReport";
			this.buttonExportReport.Size = new System.Drawing.Size(44, 30);
			this.buttonExportReport.TabIndex = 2;
			// 
			// buttonShare
			// 
			this.buttonShare.Anchor = Wisej.Web.AnchorStyles.Top;
			this.buttonShare.BackColor = System.Drawing.Color.Transparent;
			this.buttonShare.Focusable = false;
			this.buttonShare.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/share.svg";
			this.buttonShare.Location = new System.Drawing.Point(3, 103);
			this.buttonShare.Name = "buttonShare";
			this.buttonShare.Size = new System.Drawing.Size(44, 30);
			this.buttonShare.TabIndex = 3;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = Wisej.Web.AnchorStyles.Top;
			this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
			this.buttonDelete.Focusable = false;
			this.buttonDelete.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.buttonDelete.Location = new System.Drawing.Point(3, 149);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(44, 30);
			this.buttonDelete.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageSource = "Images\\wisej.png";
			this.pictureBox1.Location = new System.Drawing.Point(10, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(35, 35);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.flexLayoutPanel2);
			this.panel2.Controls.Add(this.flexLayoutPanel1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.CssStyle = "border-radius: 0px;\r\nborder-bottom: 1px solid lightgray;";
			this.panel2.Dock = Wisej.Web.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1198, 103);
			this.panel2.TabIndex = 5;
			// 
			// flexLayoutPanel2
			// 
			this.flexLayoutPanel2.Anchor = Wisej.Web.AnchorStyles.Right;
			this.flexLayoutPanel2.Controls.Add(this.radioButton4);
			this.flexLayoutPanel2.Controls.Add(this.radioButton1);
			this.flexLayoutPanel2.Controls.Add(this.radioButton2);
			this.flexLayoutPanel2.Controls.Add(this.radioButton3);
			this.flexLayoutPanel2.Controls.Add(this.radioButton6);
			this.flexLayoutPanel2.Controls.Add(this.dateTimePicker4);
			this.flexLayoutPanel2.Controls.Add(this.dateTimePicker3);
			this.flexLayoutPanel2.HeaderBackColor = System.Drawing.Color.Transparent;
			this.flexLayoutPanel2.HeaderForeColor = System.Drawing.Color.FromName("@toolbarText");
			this.flexLayoutPanel2.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/calendar2-date.svg";
			this.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel2.Location = new System.Drawing.Point(448, 13);
			this.flexLayoutPanel2.Name = "flexLayoutPanel2";
			this.flexLayoutPanel2.ShowCloseButton = false;
			this.flexLayoutPanel2.ShowHeader = true;
			this.flexLayoutPanel2.Size = new System.Drawing.Size(692, 77);
			this.flexLayoutPanel2.TabIndex = 7;
			this.flexLayoutPanel2.Text = "Selected Period";
			// 
			// radioButton4
			// 
			this.radioButton4.Enabled = false;
			this.radioButton4.Location = new System.Drawing.Point(3, 3);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(86, 43);
			this.radioButton4.TabIndex = 7;
			this.radioButton4.Text = "Yesterday";
			// 
			// radioButton1
			// 
			this.radioButton1.Enabled = false;
			this.radioButton1.Location = new System.Drawing.Point(105, 3);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(63, 43);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.Text = "Week";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(184, 3);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(69, 43);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Month";
			// 
			// radioButton3
			// 
			this.radioButton3.Enabled = false;
			this.radioButton3.Location = new System.Drawing.Point(269, 3);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(56, 43);
			this.radioButton3.TabIndex = 6;
			this.radioButton3.Text = "Year";
			// 
			// radioButton6
			// 
			this.radioButton6.Enabled = false;
			this.radioButton6.Location = new System.Drawing.Point(341, 3);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(75, 43);
			this.radioButton6.TabIndex = 8;
			this.radioButton6.Text = "Custom";
			// 
			// dateTimePicker4
			// 
			this.dateTimePicker4.Enabled = false;
			this.dateTimePicker4.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.dateTimePicker4.Label.Position = Wisej.Web.LabelPosition.Inside;
			this.dateTimePicker4.LabelText = "To";
			this.dateTimePicker4.Location = new System.Drawing.Point(432, 3);
			this.dateTimePicker4.Name = "dateTimePicker4";
			this.dateTimePicker4.Size = new System.Drawing.Size(120, 43);
			this.dateTimePicker4.TabIndex = 3;
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Enabled = false;
			this.dateTimePicker3.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.dateTimePicker3.Label.Position = Wisej.Web.LabelPosition.Inside;
			this.dateTimePicker3.LabelText = "From";
			this.dateTimePicker3.Location = new System.Drawing.Point(568, 3);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(120, 43);
			this.dateTimePicker3.TabIndex = 2;
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.Right;
			this.flexLayoutPanel1.Controls.Add(this.radioButton5);
			this.flexLayoutPanel1.Controls.Add(this.dateTimePicker1);
			this.flexLayoutPanel1.Controls.Add(this.dateTimePicker2);
			this.flexLayoutPanel1.Enabled = false;
			this.flexLayoutPanel1.HeaderBackColor = System.Drawing.Color.Transparent;
			this.flexLayoutPanel1.HeaderForeColor = System.Drawing.Color.FromName("@toolbarText");
			this.flexLayoutPanel1.ImageSource = "checkbox";
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(32, 13);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.ShowCloseButton = false;
			this.flexLayoutPanel1.ShowHeader = true;
			this.flexLayoutPanel1.Size = new System.Drawing.Size(410, 77);
			this.flexLayoutPanel1.TabIndex = 6;
			this.flexLayoutPanel1.Text = "Compare";
			this.flexLayoutPanel1.Visible = false;
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(3, 3);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(120, 43);
			this.radioButton5.TabIndex = 8;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Previous Period";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.dateTimePicker1.Label.Position = Wisej.Web.LabelPosition.Inside;
			this.dateTimePicker1.LabelText = "From";
			this.dateTimePicker1.Location = new System.Drawing.Point(139, 3);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(120, 43);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.dateTimePicker2.Label.Position = Wisej.Web.LabelPosition.Inside;
			this.dateTimePicker2.LabelText = "To";
			this.dateTimePicker2.Location = new System.Drawing.Point(275, 3);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(120, 43);
			this.dateTimePicker2.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("windowTitle", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label2.Location = new System.Drawing.Point(60, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Dashboard Manager";
			// 
			// contextMenuDashboards
			// 
			this.contextMenuDashboards.Name = "contextMenuDashboards";
			this.contextMenuDashboards.MenuItemClicked += new Wisej.Web.MenuItemEventHandler(this.contextMenuDashboards_MenuItemClicked);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.dxDashboard1);
			this.Controls.Add(this.panelDashboards);
			this.Controls.Add(this.flexLayoutPanelTools);
			this.Controls.Add(this.panel2);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(1198, 365);
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.panelDashboards.ResumeLayout(false);
			this.flexLayoutPanelTools.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.flexLayoutPanel2.ResumeLayout(false);
			this.flexLayoutPanel2.PerformLayout();
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Web.Ext.DxDashboard.DxDashboard dxDashboard1;
        private Web.Button buttonWorkingMode;
		private Web.Panel panelDashboards;
		private Web.ListBox listBox1;
		private Web.FlexLayoutPanel flexLayoutPanelTools;
		private Web.Panel panel2;
		private Web.Label label2;
		private Web.PictureBox pictureBox1;
		private Web.Button buttonAddDashboard;
		private Web.FlexLayoutPanel flexLayoutPanel1;
		private Web.FlexLayoutPanel flexLayoutPanel2;
		private Web.DateTimePicker dateTimePicker3;
		private Web.DateTimePicker dateTimePicker4;
		private Web.RadioButton radioButton4;
		private Web.RadioButton radioButton1;
		private Web.RadioButton radioButton2;
		private Web.RadioButton radioButton3;
		private Web.RadioButton radioButton5;
		private Web.DateTimePicker dateTimePicker1;
		private Web.DateTimePicker dateTimePicker2;
		private Web.RadioButton radioButton6;
		private Web.Button buttonShare;
		private Web.Button buttonExportReport;
		private Web.Button buttonDelete;
		private Web.ContextMenu contextMenuDashboards;
	}
}

