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
using System.Net;

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
		private List<Route> route_table;

		public Server()
		{
			InitializeComponent();
		}

		public Server(string proxy_table, string route_table):this()
		{
			SetProxy(proxy_table);
			SetRoute(route_table);
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

		public void SetRoute(string route_table)
		{
			string[] route = route_table.Split('\n');
			this.route_table = new List<Route>();
			foreach(var r in route)
			{
				this.route_table.Add(Route.Parse(r));
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
					stage = Name + " (" + InterfaceAdresses[port] + ") received package from " + package.StartIP;
					Logger.WriteLine(stage);
					package.AddStage(stage);
					package.PackageState = Package.State.RECEIVED;
					return;
				}

				//Пересылка дальше
				//проверка по PROXY-таблице
				bool ispass = is_pass(package);
				if(!ispass)
				{
					stage = Name + " (" + InterfaceAdresses[port] + ") DENIED package " + package;
					Logger.WriteLine(stage);
					package.AddStage(stage);
					package.PackageState = Package.State.DENIED;
					return;
				}


				//Проверка по таблице маршрутизации
				Route route = get_route(package.EndIP.Peek());
				if(route==null)
				{
					stage = Name + " (" + InterfaceAdresses[port] + ") DON'T find route for package " + package;
					Logger.WriteLine(stage);
					package.AddStage(stage);
					package.PackageState = Package.State.NO_ROUTE;
				}

				if (route.NextRouter != null)
					package.EndIP.Push(route.NextRouter);


				send(package, route.PortNo);
			}
			else
			{
				package.PackageState = Package.State.REJECTED;
				stage = Name + " (" + InterfaceAdresses[0] + ") rejected package " + package;

				Logger.WriteLine(stage);
				package.AddStage(stage);
			}
		}

		//Отправка
		private void send(Package package, int port)
		{
			//Проверяем, находится ли получатель в той же подсети
			if (InterfaceAdresses[port].IsInSameSubnet(package.EndIP.Peek()))
				send(port, package);
			else
				Debug.Write(Name + " (" + InterfaceAdresses[port] + ") DIDN'T send package " + package + " to " + ConnectedDevices[port].Name + ": OTHER SUBNET");
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

		private Route get_route(IPAddress adress)
		{
			foreach(var route in route_table)
			{
				if ((route.Destination == null) || (IPAddressWithMask.IsInSameSubnet(adress, route.Destination, route.Mask)))
					return route;
			}

			return null;
		}
	}
}
