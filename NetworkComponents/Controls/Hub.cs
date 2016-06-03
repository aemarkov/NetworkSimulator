using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkComponents.Controls
{
	public partial class Hub : AbstractNetworkDevice
	{
		protected override int InterfacesCount { get { return 8; } }

		public Hub()
		{
			InitializeComponent();

		}

		/*
		 * Рассылает пакет на все порты, кроме того, на который он пришел
		 */
		public override void ProcessPackage(Package package, AbstractNetworkDevice sender)
		{
			foreach(var device in connected_devices)
			{
				if (!device.Value.Equals(sender))
					send(device.Key, package);
			}
		}
	}
}
