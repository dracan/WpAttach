﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using EnvDTE80;

namespace WpAttach
{
	public partial class ProcessList : Form
	{
		private DTE2 _applicationObject;

		public ProcessList(DTE2 applicationObject)
		{
			_applicationObject = applicationObject;

			InitializeComponent();
		}

		private void ProcessList_Load(object sender, EventArgs e)
		{
			lbProcesses.DisplayMember = "Owner";
			lbProcesses.ValueMember = "PID";
			lbProcesses.DataSource = GetW3WPProcesses();
		}

		public List<ProcessInfo> GetW3WPProcesses()
		{
			return (from EnvDTE.Process p in _applicationObject.Debugger.LocalProcesses
					where p.Name.Contains("w3wp")
			        select new ProcessInfo
			        {
			            PID = p.ProcessID,
			            Owner = GetProcessOwner(p.ProcessID),
						EnvDteProcess = p
			        }).ToList();
		}

		public static string GetProcessOwner(int processId)
		{
			var query = "Select * From Win32_Process Where ProcessID = " + processId;
			var searcher = new ManagementObjectSearcher(query);
			var processList = searcher.Get();

			foreach(ManagementObject obj in processList)
			{
				string[] argList = new[] { string.Empty, string.Empty };
				int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
				if (returnVal == 0)
				{
				    // return DOMAIN\user
				    return argList[1] + "\\" + argList[0];
				}
			}

			return "";
		}

		private void lbProcesses_DoubleClick(object sender, EventArgs e)
		{
			if(lbProcesses.SelectedItem != null)
			{
				var procInfo = (ProcessInfo)lbProcesses.SelectedItem;

				procInfo.EnvDteProcess.Attach();

				Close();
			}
		}

		private void lbProcesses_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch(e.KeyChar)
			{
				case (char)Keys.Return:
				{
					if(lbProcesses.SelectedItem != null)
					{
						var procInfo = (ProcessInfo)lbProcesses.SelectedItem;

						procInfo.EnvDteProcess.Attach();

						Close();
					}

		            e.Handled = true;
					break;
				}

				case (char)Keys.Escape:
				{
		            e.Handled = true;
					Close();
					break;
				}
			}
		}
	}
}
