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
	/// Сервер с 2мя портами
	/// </summary>
	public partial class Server : AbstractNetworkDevice
	{
		public override int InterfacesCount { get { return 2; } }

		public Server()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Задает таблицы
		/// </summary>
		/// <param name="proxy_table">Прокси-таблица</param>
		/// <param name="route_table">Таблица маршрутизации</param>
		public void SetupServer(string proxy_table, string route_table)
		{

		}
		
		public override void ProcessPackage(Package package, AbstractNetworkDevice sender)
		{
		}
	}
}
