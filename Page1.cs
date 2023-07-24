using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Web;
using System.Collections.Generic;
using System.IO;
using System;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.DxDashboardSample
{
	public partial class Page1 : Page
	{
		private DashboardHelper _dashboardHelper;

		//set this variable to set the folder where the dashboards will be stored
		private string dashboardStorageFolder = "Data/Dashboards";

		public Page1()
		{
			InitializeComponent();
		}
		List<string> fileNames;
		private void Page1_Load(object sender, System.EventArgs e)
		{
			this.dxDashboard.Options.endpoint = $"{this.dxDashboard.GetServiceURL()}";

			this._dashboardHelper = new DashboardHelper(DashboardConfigurator.Default);

			DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
			DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(Application.MapPath(dashboardStorageFolder)));

			PopulateDashboards(Application.MapPath(dashboardStorageFolder));
		}

		private void dxDashboard_WebRequest(object sender, WebRequestEventArgs e)
		{
			this._dashboardHelper.ProcessRequest(sender, e);
		}

		private void buttonWorkingMode_Click(object sender, System.EventArgs e)
		{
			var workingMode = this.dxDashboard.Options.workingMode;
			this.dxDashboard.Options.workingMode = workingMode == "Designer" ? "viewerOnly" : "Designer";
		}

		private void listBoxDashboardList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.dxDashboard.Instance.loadDashboard(listBoxDashboardList.SelectedItem.ToString());
		}

		// get a list of the dashboard files and populate the ListBox with the contents of the list
		// so the user can click on any dashboard in the list and have it loaded
		void PopulateDashboards(string folderPath)
		{
			List<string> fileNames = new List<string>();

			try
			{
				// Check if the directory exists
				if (Directory.Exists(folderPath))
				{
					// Get all files in the directory and add their names to the list
					string[] files = Directory.GetFiles(folderPath);
					foreach (string file in files)
					{
						string filenameWithExtension = Path.GetFileName(file);
						string filenameWithoutExtension = Path.GetFileNameWithoutExtension(filenameWithExtension);
						fileNames.Add(filenameWithoutExtension);
					}
				}
				else
				{
					AlertBox.Show("The specified directory does not exist.");
				}
			}
			catch (Exception ex)
			{
				AlertBox.Show("An error occurred: " + ex.Message);
			}

			listBoxDashboardList.DataSource = fileNames;
		}

		void cloneDashboardTemplate(string name)
		{
			string sourceFilePath = Application.MapPath(dashboardStorageFolder) + @"/dashboardtemplate.xml";
			string destinationFilePath = Application.MapPath(dashboardStorageFolder) + $@"/{name}.xml";

			try
			{
				// Copy the file
				File.Copy(sourceFilePath, destinationFilePath);

				//Refresh the list of dashboards to show the new dashboard
				PopulateDashboards(Application.MapPath(dashboardStorageFolder));

				//load the new dashboard
				this.dxDashboard.Instance.loadDashboard(name);

				AlertBox.Show("Dashboard template cloned successfully!");
			}
			catch (IOException ex)
			{
				AlertBox.Show("An error occurred while creating the template: " + ex.Message);
			}
		}

		private void splitButtonCreateDashboard_Click(object sender, EventArgs e)
		{
			AlertBox.Show("New dashboard created: NewDashboard");
			cloneDashboardTemplate("NewDashboard");
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			//saves all changes to the open dashboards
			this.dxDashboard.Instance.saveDashboard();
		}

		private void splitButtonCreateDashboard_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
		{
			// Create a dashboard named after the item that was selected
			AlertBox.Show("New dashboard created: "+e.Item.Text);
			cloneDashboardTemplate(e.Item.Text);
		}
	}
}
