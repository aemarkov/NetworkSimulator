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
	/// <summary>
	/// Шлюз
	/// </summary>
	public partial class Gate : AbstractNetworkDevice
	{
		public override int InterfacesCount { get { return 1; } }

		public Gate()
		{
			InitializeComponent();
		}

		/*
		 * Если адрес получителя совпадает - то принимаем пакет, 
		 * иначе - откланяет
		 */
		public override void ProcessPackage(Package package, AbstractNetworkDevice sender)
		{
			string stage;
			//Адресован ли пакет нам
			if (package.EndIP.Peek().Equals(InterfaceAdresses[0].IP))
			{
				package.PackageState = Package.State.RECEIVED;
				stage = Name + " (" + InterfaceAdresses[0] + ") received package " + package + " from " + package.StartIP;
			}
			else
			{
				package.PackageState = Package.State.REJECTED;
				stage = Name + " (" + InterfaceAdresses[0] + ") rejected package " + package;
			}

			Logger.WriteLine(stage);
			package.AddStage(stage);
			PackageManager.AddPackage(package);
		}
	}
}
