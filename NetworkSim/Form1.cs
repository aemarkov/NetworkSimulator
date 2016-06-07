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

            Logger.TextWrited += Logger_TextWrited;
			PackageManager.NewPackage += PackageManager_NewPackage;
			AbstractNetworkDevice.SendingDrawDelay = 1000;
			AbstractNetworkDevice.Drawer = netDrawer1;
            table_packages.CellClick += Table_packages_CellClick;

        }

		private void Form1_Load(object sender, EventArgs e)
		{

            //G1
            pcGroup1.SetPCs("197.253.85.3", "197.253.85.4", "255.255.255.128", "197.253.85.2");
            pcGroup11.SetPCs("197.253.85.130", "197.253.85.131", "255.255.255.128", "197.253.85.2");
            pcGroup1.Connect(hub1, 1);
            pcGroup11.Connect(hub1, 3);

            //S1
            server1.SetIP("197.253.85.2/24", "197.253.91.2/24");
            server1.SetRoute(
                @"197.253.67.0;255.255.255.0;197.253.91.1;1
                  197.253.85.0;255.255.255.0;-;0");
            server1.SetProxy(
                @"197.253.85.3-197.253.85.4;any;pass
                  197.253.85.130-197.253.85.131;any;deny
                  197.253.67.10;any;pass");
            //server1.SetProxy("any;any;pass");

            hub1.DuplexConnect(0, 0, server1);

            //G2
            pcGroup2.SetPCs("197.253.86.3", "197.253.86.4", "255.255.255.0", "197.253.86.2");
            pcGroup21.SetPCs("192.168.1.2", "192.168.1.3", "255.255.255.0", "192.168.1.1");     //Серые
            pcGroup2.Connect(hub2, 2);
            pcGroup21.Connect(hub21, 1);

            //S2
            server2.SetIP("197.253.86.2/24", "197.253.92.2/24");
            server2.SetProxy("any;any;pass");
            hub2.DuplexConnect(0, 0, server2);

            //S21
            server21.SetIP("192.168.1.1/24", "197.253.86.100/24");
            server21.SetProxy("any;any;pass");
            server21.SetRoute(
                @"192.168.1.0;255.255.255.0;-;0
                  197.253.0.0;255.255.0.0;197.253.86.2;1");

            hub21.DuplexConnect(0, 0, server21);
            server21.DuplexConnect(1, 1, hub2);

            //S
            server.SetIP("197.253.91.1/24", "197.253.92.1/24", "197.253.93.1/24", "197.253.67.1/24");
            server.SetProxy("any;any;pass");
            server.SetRoute(
                @"197.253.67.10;255.255.255.255;-;3
                  197.253.85.0;255.255.255.0;197.253.91.2;0");

            //Admin
            admin.SetIP("197.253.67.10/24");
            admin.SetGateway("197.253.67.1");

            //G1->S
            server1.DuplexConnect(1, 0, server);

            //G2->S
            server2.DuplexConnect(1, 1, server);

            //S->Admin
            server.DuplexConnect(3, 0, admin);


			


			/*pcGroup1.SetPCs("192.168.1.2", "192.168.1.3", "255.255.255.0", "192.168.1.1");

			admin.SetIP("192.168.2.10/24");
			admin.SetGateway("192.168.2.1");

			pc1.SetIP("192.168.2.11/24");
			pc1.SetGateway("192.168.2.1");

			server1.SetIP("192.168.1.1/24", "192.168.2.1/24");
			server1.SetProxy(
				@"any;any;pass");

			server1.SetRoute(
				@"192.168.2.0;255.255.255.0;-;1
                  192.168.1.0;255.255.255.0;-;0");

			pcGroup1.Connect(hub1, 1);
			hub1.DuplexConnect(0, 0, server1);
			server1.DuplexConnect(1, 0, hub2);
			hub2.DuplexConnect(1, 0, admin);*/

			netDrawer1.Init();
			netDrawer1.UpdateConnections();
			animTimer.Start();
			
			//pc1.SendPackage(new NetworkComponents.Package("192.168.1.131"));
		}


		#region EVENTS

		//Новый пакет сгенерирован
		private void PackageManager_NewPackage(Package pckg)
		{
			this.InvokeEx(x =>
			{
				x.table_packages.Rows.Clear();

				foreach (var package in PackageManager.Pacakges)
				{
					int id = x.table_packages.Rows.Add();
					x.table_packages.Rows[id].Cells[0].Value = package.ToString();
					x.table_packages.Rows[id].Cells[1].Value = package.PackageState;

					if (package.PackageState == Package.State.SENDING)
						x.table_packages.Rows[id].DefaultCellStyle.BackColor = Color.Yellow;
					else if (package.PackageState == Package.State.RECEIVED)
						x.table_packages.Rows[id].DefaultCellStyle.BackColor = Color.Green;
					else
						x.table_packages.Rows[id].DefaultCellStyle.BackColor = Color.Red;
				}
			});
		}

		//Новое сообщение в лог
		private void Logger_TextWrited(string obj)
		{
			this.InvokeEx(x => x.txtLog.Text += obj);

			//txtLog.Text += obj;
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

		private void animTimer_Tick(object sender, EventArgs e)
		{
			netDrawer1.UpdateAnimation((uint)animTimer.Interval);
		}
	}
}
