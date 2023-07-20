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

		public Page1()
		{
			InitializeComponent();
		}
		List<string> fileNames;
		private void Page1_Load(object sender, System.EventArgs e)
		{
			this.dxDashboard1.Options.endpoint = $"{this.dxDashboard1.GetServiceURL()}";

			this._dashboardHelper = new DashboardHelper(DashboardConfigurator.Default);

			DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
			DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(Application.MapPath("Data/Dashboards")));


			//get a list of the dashboard files and populate the ListBox with the contents of the list
			//so the user can click on any dashboard in the list and have it loaded
			fileNames = GetFileNamesInFolder("./Data/Dashboards");
			listBox1.DataSource = fileNames;
		}

		private void dxDashboard1_WebRequest(object sender, WebRequestEventArgs e)
		{
			this._dashboardHelper.ProcessRequest(sender, e);
		}

		private void buttonWorkingMode_Click(object sender, System.EventArgs e)
		{
			var workingMode = this.dxDashboard1.Options.workingMode;
			this.dxDashboard1.Options.workingMode = workingMode == "Designer" ? "viewerOnly" : "Designer";
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			AlertBox.Show(listBox1.SelectedItem.ToString());
			this.dxDashboard1.Instance.loadDashboard(listBox1.SelectedItem.ToString());
		}

		List<string> GetFileNamesInFolder(string folderPath)
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

			return fileNames;
		}
	}
}
