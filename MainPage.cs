using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Web;
using System.Collections.Generic;
using System.IO;
using System;
using Wisej.Core;
using Wisej.Web;
using DevExpress.DashboardCommon;

namespace Wisej.DxDashboardSample
{
	public partial class MainPage : Page
	{
		private DashboardHelper _dashboardHelper;

		//set this variable to set the folder where the dashboards will be stored
		private static string DASHBOARD_STORAGE = Application.MapPath("Data/Dashboards");
		private static string TEMPLATE_STORAGE = Application.MapPath("Data/Templates");

		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			this.dxDashboard1.Options.workingMode = "viewerOnly";
			this.dxDashboard1.Options.endpoint = $"{this.dxDashboard1.GetServiceURL()}";

			this._dashboardHelper = new DashboardHelper(DashboardConfigurator.Default);

			DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
			DashboardConfigurator.Default.CustomParameters += DashboardConfigurator_CustomParameters;
			DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(DASHBOARD_STORAGE));

			PopulateTemplates();
			PopulateMyDashboards();	
		}

		private void DashboardConfigurator_CustomParameters(object sender, CustomParametersEventArgs e)
		{
			//Set agency, month, year parameters
			foreach(var param in e.Parameters)
			{
				if (param.Name == "Month")
				{
					param.Value = "05";
				}
				else if (param.Name == "Year")
				{
					param.Value = "2016";
				}
				else if (param.Name == "Agency")
				{
					param.Value = "01";
				}
			}
		}

		private void dxDashboard1_WebRequest(object sender, WebRequestEventArgs e)
		{
			this._dashboardHelper.ProcessRequest(sender, e);
		}

		private void buttonWorkingMode_Click(object sender, EventArgs e)
		{
			var workingMode = this.dxDashboard1.Options.workingMode;
			this.dxDashboard1.Options.workingMode = workingMode == "Designer" ? "viewerOnly" : "Designer";
		}

		private void listBoxDashboards_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.dxDashboard1.Instance.loadDashboard(listBox1.SelectedItem.ToString().Replace(" ", "_"));
		}

		private void PopulateTemplates()
		{
			// Check if the directory exists
			if (Directory.Exists(TEMPLATE_STORAGE))
			{
				// Get all files in the directory and add their names to the list
				var files = Directory.GetFiles(TEMPLATE_STORAGE);
				foreach (string file in files)
				{
					string filenameWithExtension = Path.GetFileName(file);
					string filenameWithoutExtension = Path.GetFileNameWithoutExtension(filenameWithExtension);

					this.contextMenuDashboards.MenuItems.Add(filenameWithoutExtension.Replace("_", " "));
				}
			}
			else
			{
				AlertBox.Show("The specified directory does not exist.");
			}
		}

		private void PopulateMyDashboards()
		{
			var fileNames = new List<string>();

			// Check if the directory exists
			if (Directory.Exists(DASHBOARD_STORAGE))
			{
				// Get all files in the directory and add their names to the list
				var files = Directory.GetFiles(DASHBOARD_STORAGE);
				foreach (string file in files)
				{
					string filenameWithExtension = Path.GetFileName(file);
					string filenameWithoutExtension = Path.GetFileNameWithoutExtension(filenameWithExtension);
						
					fileNames.Add(filenameWithoutExtension.Replace("_", " "));
				}
			}
			else
			{
				AlertBox.Show("The specified directory does not exist.");
			}

			this.listBox1.DataSource = fileNames;
		}

		private void CreateDashboardFromTemplate(string templateName)
		{
			var templatePath = Path.Combine(TEMPLATE_STORAGE, $"{templateName}.xml");
			var destinationPath = Path.Combine(DASHBOARD_STORAGE, $"{templateName}.xml");

			try
			{
				if (File.Exists(destinationPath))
				{
					var result = MessageBox.Show("Override with new dashboard?", "Dashboard Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
					if (result == DialogResult.No)
						return;
				}

				// Copy the file
				File.Copy(templatePath, destinationPath, true);

				//Refresh the list of dashboards to show the new dashboard
				PopulateMyDashboards();

				//load the new dashboard
				var name = templateName.Replace("_", " ");
				this.listBox1.SelectedItem = name;

				AlertBox.Show($"Created Dashboard: {name}");
			}
			catch (IOException ex)
			{
				AlertBox.Show("An error occurred while creating the template: " + ex.Message);
			}
		}

		private void buttonAddDashboard_Click(object sender, EventArgs e)
		{
			this.contextMenuDashboards.Show(this.buttonAddDashboard, Placement.TopCenter);
		}

		private void contextMenuDashboards_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			var templateName = e.MenuItem.Text;
			CreateDashboardFromTemplate(templateName.Replace(" ", "_"));
		}
	}
}
