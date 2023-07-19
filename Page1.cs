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

		private void Page1_Load(object sender, System.EventArgs e)
		{
			this.dxDashboard1.Options.endpoint = $"{this.dxDashboard1.GetServiceURL()}";

			this._dashboardHelper = new DashboardHelper(DashboardConfigurator.Default);

			DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
			DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(Application.MapPath("Data/Dashboards")));


			//get a list of the dashboard files and populate the ListBox with the contents of the list
			//so the user can click on any dashboard in the list and have it loaded
			List<string> fileNames = GetFileNamesInFolder("./Data/Dashboards");
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
			if(listBox1.SelectedIndex == 0)
			{
				AlertBox.Show("selected 0");
				this.dxDashboard1.Instance.loadDashboard("dashboard1");
			}
			else
				if(listBox1.SelectedIndex == 1)
			{
				AlertBox.Show("selected 1");
				this.dxDashboard1.Instance.loadDashboard("dashboard2");
			}
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
						fileNames.Add(Path.GetFileName(file));
					}
				}
				else
				{
					Console.WriteLine("The specified directory does not exist.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("An error occurred: " + ex.Message);
			}

			return fileNames;
		}
	}
}
