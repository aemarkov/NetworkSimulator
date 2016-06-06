using NetworkComponents;
using NetworkComponents.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			Logger.TextWrited += Logger_TextWrited;
			PackageManager.NewPackage += PackageManager_NewPackage;
			table_packages.CellClick += Table_packages_CellClick;


			pcGroup1.SetPCs("192.168.1.2", "192.168.1.3", "255.255.255.0", "192.168.1.1");
			pcGroup2.SetPCs("192.168.2.2", "192.168.2.3", "255.255.255.0", "192.168.2.1");

			server1.SetIP("192.168.1.1/24", "192.168.10.1/24", "192.168.100.1/24", "192.168.100.1/24");
			server3.SetIP("192.168.2.1/24", "192.168.11.1/24");
			server2.SetIP("192.168.10.2/24", "192.168.11.2/24");
			

			pcGroup1.Connect(hub1, 1);
			pcGroup2.Connect(hub2, 1);

			hub1.DuplexConnect(0, 0, server1);
			hub2.DuplexConnect(0, 0, server3);

			server1.DuplexConnect(1, 0, server2);
			server3.DuplexConnect(1, 1, server2);


			netDrawer1.Init();
			netDrawer1.UpdateConnections();

			
			//pc1.SendPackage(new NetworkComponents.Package("192.168.1.131"));
		}


		#region EVENTS

		//Новый пакет сгенерирован
		private void PackageManager_NewPackage(Package pckg)
		{
			table_packages.Rows.Clear();

			foreach (var package in PackageManager.Pacakges)
			{
				int id = table_packages.Rows.Add();
				table_packages.Rows[id].Cells[0].Value = package.ToString();
				table_packages.Rows[id].Cells[1].Value = package.PackageState;

				if (package.PackageState == Package.State.SENDING)
					table_packages.Rows[id].DefaultCellStyle.BackColor = Color.Yellow;
				else if (package.PackageState == Package.State.RECEIVED)
					table_packages.Rows[id].DefaultCellStyle.BackColor = Color.Green;
				else
					table_packages.Rows[id].DefaultCellStyle.BackColor = Color.Red;
			}
		}

		//Новое сообщение в лог
		private void Logger_TextWrited(string obj)
		{
			txtLog.Text += obj;
		}

		//Удаление всех пакетов из мониторинга
		private void btnReset_Click(object sender, EventArgs e)
		{
			PackageManager.Reset();
			table_packages.Rows.Clear();
			txtLog.Text = "";
			trace_details.Text = "";
		}

		private void Table_packages_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;

			var package = PackageManager.Pacakges[e.RowIndex];

			trace_details.Text = "";
			int i = 1;
			foreach (var stage in package.Trace)
			{
				trace_details.Text += i + ". " + stage + Environment.NewLine; ;
				i++;
			}

			trace_details.Text += Environment.NewLine + "STATUS: " + package.PackageState;
		}

		#endregion
	}
}
