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
			//hub1.Name = "hub1";

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


			pc1.DuplexConnect(0, 0, server1);
			server1.DuplexConnect(1, 0, hub1);
			hub1.DuplexConnect(1, 0, pc2);
			hub1.DuplexConnect(2, 0, pc3);

			pc1.SendPackage(new NetworkComponents.Package("192.168.1.131"));
		}
	}
}
