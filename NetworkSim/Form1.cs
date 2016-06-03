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
			hub1.Name = "hub1";

			pc1.SetIP("192.168.1.1");
			pc2.SetIP("192.168.1.2");
			pc3.SetIP("192.168.1.3");

			pc1.DuplexConnect(0, 0, hub1);
			hub1.DuplexConnect(1, 0, pc2);
			hub1.DuplexConnect(2, 0, pc3);

			pc1.SendPackage(new NetworkComponents.Package() { EndIP = "192.168.1.2" });
		}
	}
}
