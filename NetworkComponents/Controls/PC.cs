using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetworkComponents.Controls
{
	/// <summary>
	/// ПК. Имеет один порт.
	/// Может отсылать пакет, принимать пакет, но не 
	/// может пересылать пакет
	/// </summary>
	public partial class PC : AbstractNetworkDevice
	{
		public override int InterfacesCount { get { return 1; } }

		public PC()
		{
			InitializeComponent();
		}

		/*
		 * Если адрес получителя совпадает - то принимаем пакет, 
		 * иначе - откланяет
		 */
		public override void ProcessPackage(Package package, AbstractNetworkDevice sender)
		{
			if (package.EndIP.Equals(InterfaceAdresses[0].IP) && InterfaceAdresses[0].IsInSameSubnet(package.StartIP))
			{
				package.PackageState = Package.State.RECEIVED;
				Debug.WriteLine(Name + " ("+InterfaceAdresses[0]+") received package from " + package.StartIP);
			}
			else
			{
				package.PackageState = Package.State.REJECTED;
				Debug.WriteLine(Name + " ("+InterfaceAdresses[0]+") rejected package "+package);
			}
		}

		/// <summary>
		/// Отправляет пакет, начинает пересылку
		/// </summary>
		/// <param name="package">Пакет</param>
		public void SendPackage(Package package)
		{
			package.StartIP = InterfaceAdresses[0].IP;
			send(0, package);
		}
	}
}
