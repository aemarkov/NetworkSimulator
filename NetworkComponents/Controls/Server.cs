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
	/// Сервер с 2мя портами
	/// </summary>
	public partial class Server : AbstractNetworkDevice
	{
		public int InterfacesCount_U { get; set; } = 2;
		public override int InterfacesCount { get { return InterfacesCount_U; } }

		//PROXY-таблица
		private List<Proxy> proxy_table;

		public Server()
		{
			InitializeComponent();
		}

		public Server(string proxy_table):this()
		{
			SetProxy(proxy_table);
		}

		//Задает Proxy-таблицу
		public void SetProxy(string proxy_table)
		{
			string[] proxy = proxy_table.Split('\n');
			this.proxy_table = new List<Proxy>();
			foreach (var p in proxy)
			{
				this.proxy_table.Add(Proxy.Parse(p));
			}
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
			//Порт, на который пришел пакет
			int port = ConnectedDevices.First(x => x.Value == sender).Key;
			string stage;

			//Адресован ли пакет нам
			if (package.EndIP.Peek().Equals(InterfaceAdresses[port].IP))
			{
				//Убираем верхний адрес в пакете
				//Если ничего нет больше - пакет адресован роутеру,
				//если есть - надо слать дальше

				package.EndIP.Pop();
				if (package.EndIP.Count == 0)
				{
					package.PackageState = Package.State.RECEIVED;
					stage = Name + " (" + InterfaceAdresses[port] + ") received package from " + package.StartIP;
					Debug.WriteLine(stage);
					package.AddStage(stage);
					return;
				}

				//Пересылка дальше
				Fbool ispass = is_pass(package);
			}
			else
			{
				package.PackageState = Package.State.REJECTED;
				stage = Name + " (" + InterfaceAdresses[0] + ") rejected package " + package;

				Debug.WriteLine(stage);
				package.AddStage(stage);
			}
		}


		//Проверяет пакет по proxy-таблице
		private bool is_pass(Package package)
		{
			foreach(var proxy in proxy_table)
			{
				if(
					((proxy.SenderAdress==null)||(proxy.SenderAdress.Equals(package.StartIP))) && 
					((proxy.ReceiverAdress==null)||(proxy.ReceiverAdress.Equals(package.EndIP.Peek())))
				)
				{
					return proxy.IsPass;
				}
			}

			return false;
		}
	}
}
