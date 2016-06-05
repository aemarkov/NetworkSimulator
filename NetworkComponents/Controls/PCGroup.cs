using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace NetworkComponents.Controls
{
	public partial class PCGroup : UserControl, IMovable
	{
		public List<PC> pcs { get; private set; }

		public Mover Mover { get; private set; }

		public PCGroup()
		{
			InitializeComponent();
			pcs = new List<PC>();

			Mover = new Mover(this);
		}

		/// <summary>
		/// Создает компы с адресами в диапазоне
		/// </summary>
		/// <param name="start_ip"></param>
		/// <param name="end_ip"></param>
		/// <param name="mask"></param>
		public void SetPCs(IPAddress start_ip, IPAddress end_ip, IPAddress mask, IPAddress gateway )
		{
			var tools = new IPAddressTools.RangeFinder();
			var ips = tools.GetIPRange(start_ip, end_ip);

			pcs.Clear();

			foreach(var ip in ips)
			{
				var pc = new PC();
				pc.Left = -1000;
				pc.Top = -1000;
				pc.SetIP(new IPAddressWithMask(ip, mask));
				pc.Gateway = gateway;
				pcs.Add(pc);
			}

			lblIPStart.Text = start_ip.ToString();
			lblIPEnd.Text = end_ip.ToString();
			fill_combo_box();
		}

		
		/// <summary>
		/// Подключает пекарни к устройству
		/// </summary>
		/// <param name="device">Устройство</param>
		/// <param name="ports">Список портов</param>
		public void Connect(AbstractNetworkDevice device, params int[] ports)
		{
			if (ports.Length != pcs.Count)
				throw new ArgumentException("Number of ports to connect must be equal to PCs count");

			for(int i = 0; i < pcs.Count; i++)
			{
				pcs[i].DuplexConnect(0, ports[i], device);
			}

		}

		/// <summary>
		/// Подключает пекарни к устройству
		/// </summary>
		/// <param name="device">Устройство</param>
		/// <param name="start_port">начальный порт</param>
		public void Connect(AbstractNetworkDevice device, int start_port)
		{

			for(int i=0; i<pcs.Count; i++)
			{
				pcs[i].DuplexConnect(0, start_port + i, device);
			}

		}

		private void fill_combo_box()
		{
			foreach (var pc in pcs)
			{
				comboIPs.Items.Add(pc.InterfaceAdresses[0]);
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (comboIPs.SelectedIndex != -1)
			{
				try
				{
					var pc = pcs[comboIPs.SelectedIndex];
					pc.SendPackage(new Package(textBox1.Text));
				}
				catch(FormatException exp)
				{
					MessageBox.Show("Invalid IP address");
				}
			}
		}
	}
}
