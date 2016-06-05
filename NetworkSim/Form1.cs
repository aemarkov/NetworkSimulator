using NetworkComponents;
using NetworkComponents.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

			server1.SetIP("192.168.1.1/25", "192.168.1.130/25");
			server1.SetProxy(
				@"192.168.1.2;192.168.1.131;pass
				  192.168.1.131;192.168.1.2;pass
				  any;any;deny");

			server1.SetRoute(
				@"192.168.1.128;255.255.255.128;-;1
				  192.168.1.0;255.255.255.128;-;0");

			pc1.SetIP("192.168.1.2/25");
			pc1.SetGateway("192.168.1.1");

			pc2.SetIP("192.168.1.3/25");
			pc2.SetGateway("192.168.1.1");


			pc3.SetIP("192.168.1.131/25");
			pc3.SetGateway("192.168.1.130");

			pc4.SetIP("192.168.1.132/25");
			pc4.SetGateway("192.168.1.130");


			pc1.DuplexConnect(0, 0, hub1);
			pc2.DuplexConnect(0, 1, hub1);
			hub1.DuplexConnect(2, 0, server1);

			server1.DuplexConnect(1, 2, hub2);
			hub2.DuplexConnect(0, 0, pc3);
			hub2.DuplexConnect(1, 0, pc4);


			netDrawer1.Init();
			netDrawer1.UpdateConnections();

			
			pc1.SendPackage(new NetworkComponents.Package("192.168.1.131"));
		}

		//Новый пакет сгенерирован
		private void PackageManager_NewPackage(Package obj)
		{
			listBoxPackages.Items.Add(obj);
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
		}

		private void listBoxPackages_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxPackages.SelectedIndex!=-1)
			{
				var package = (Package)listBoxPackages.Items[listBoxPackages.SelectedIndex];

				trace_details.Items.Clear();
				foreach(var stage in package.Trace)
				{
					trace_details.Items.Add(stage);
				}

				trace_details.Items.Add("STATUS: " + package.PackageState);

			}
		}
	}
}
