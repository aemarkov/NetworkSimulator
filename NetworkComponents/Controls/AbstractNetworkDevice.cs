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
using System.Collections.ObjectModel;
using System.Timers;

namespace NetworkComponents.Controls
{
	/// <summary>
	/// Абстрактный класс сетевого устройства
	/// </summary>
	public partial class AbstractNetworkDevice : UserControl, IMovable
	{
		public Mover Mover { get; private set; }

		/// <summary>
		/// Колисчество интерфейсов
		/// </summary>
		public virtual int InterfacesCount { get; private set; }

		//Список подключенных устройств
		//Ключ - номер порта, к которому подключено устройство
		protected Dictionary<int,AbstractNetworkDevice> ConnectedDevices { get; set; }

		/// <summary>
		/// Список подключений (только для чтения)
		/// </summary>
		public ReadOnlyDictionary<int,AbstractNetworkDevice> Connections { get { return new ReadOnlyDictionary<int, AbstractNetworkDevice>(ConnectedDevices); } }

		//IP адерес этого устройств
		public IPAddressWithMask[] InterfaceAdresses { get; private set; }

		/// <summary>
		/// Название (для визуализации)
		/// </summary>
		public new string Name
		{
			get { return lblName.Text; }
			set { lblName.Text = value; }
		}

		/////////////////////////////////////////////////////////////////////////////////////////////////
		/// НАСТРОЙКА
		/////////////////////////////////////////////////////////////////////////////////////////////////

		public AbstractNetworkDevice()
		{
			InitializeComponent();
			this.Load += AbstractNetworkDevice_Load;
			ConnectedDevices = new Dictionary<int, AbstractNetworkDevice>();

			Mover = new Mover(this);
		}

		private void AbstractNetworkDevice_Load(object sender, EventArgs e)
		{
			StringBuilder builder = new StringBuilder();

			//Пишем номера портов на форме
			for (int i = 0; i < InterfacesCount; i++)
				builder.Append(i).Append(" ");

			lblPorts.Text = builder.ToString();
		}


		/// <summary>
		/// Устанавливает адреса интерфейсов
		/// </summary>
		/// <param name="ips">IP-адрес</param>
		public  void SetIP(params IPAddressWithMask[] ips)
		{
			if (ips.Length != InterfacesCount)
				throw new ArgumentException("Invalid number of IP adresses");

			InterfaceAdresses = ips;
			display_interfaces();
		}

		public virtual void SetIP(params String[] ips)
		{
			//if (ips.Length != InterfacesCount)
			//	throw new ArgumentException("Invalid number of IP adresses");
			InterfacesCount = ips.Length;

			InterfaceAdresses = new IPAddressWithMask[InterfacesCount];
			for (int i = 0; i < ips.Length; i++)
				InterfaceAdresses[i] = new IPAddressWithMask(ips[i]);

			display_interfaces();
		}

		private void display_interfaces()
		{
			StringBuilder builder = new StringBuilder();

			if (InterfaceAdresses == null)
			{
				//Пишем номера портов на форме
				for (int i = 0; i < InterfacesCount; i++)
					builder.Append(i).Append(" ");
			}
			else
			{
				//Пишем порты и адреса на форме:
				for (int i = 0; i < InterfacesCount; i++)
					builder.Append(i).Append(": ").Append(InterfaceAdresses[i]).Append(Environment.NewLine);
			}

			lblPorts.Text = builder.ToString();
		}

		/// <summary>
		/// Подключает другое устройство к этому устройству
		/// </summary>
		/// <param name="port_number">Номер порта, к которому подключается</param>
		/// <param name="device">Подключаемое устройство</param>
		/// <returns></returns>
		public void Connect(int port_number, AbstractNetworkDevice device)
		{
			if ((port_number < 0) || (port_number >= InterfacesCount))
				throw new NoSuchInterfaceException(port_number);

			if (ConnectedDevices.ContainsKey(port_number))
				throw new InterfaceAlreadyConnectedException();

			ConnectedDevices.Add(port_number, device);
		}

		/////////////////////////////////////////////////////////////////////////////////////////////////
		/// СЕТЕВОЕ ПОВЕДЕНИЕ
		/////////////////////////////////////////////////////////////////////////////////////////////////

		/// <summary>
		/// Подключает другое устройство к этому устройству
		/// </summary>
		/// <param name="port_number">Номер порта, к которму подключается</param>
		/// <param name="other_port_number">Номер порта на другом устройстве, которым оно полкючается</param>
		/// <param name="device">Подключаемое устройство</param>
		public void DuplexConnect(int port_number, int other_port_number, AbstractNetworkDevice device)
		{
			Connect(port_number, device);
			device.Connect(other_port_number, this);
		}

		/// <summary>
		/// "Событие" получения пакета
		/// </summary>
		/// <param name="package">Входящий пакет</param>
		public void ReceivePacakge(Package package, AbstractNetworkDevice sender)
		{
			ProcessPackage(package, sender);
		}

		/// <summary>
		/// Обработка пакета
		/// </summary>
		/// <param name="package"></param>
		public virtual void ProcessPackage(Package package, AbstractNetworkDevice sender) { }

	
		//----------------------------------------------

		//Отправляет пакет
		protected void send(int port, Package package)
		{
			if (!ConnectedDevices.ContainsKey(port))
				throw new ArgumentException("Device to this port not connected");

			var timer = new System.Timers.Timer(2000);
			timer.Elapsed += new System.Timers.ElapsedEventHandler(delegate (object sender, ElapsedEventArgs args)
			  {
				  PackageManager.AddPackage(package);

				  String stage;
				  if (InterfaceAdresses != null)
					  stage = TraceToString(Name, InterfaceAdresses[port], port, ConnectedDevices[port].Name, package);
				  else
					  stage = TraceToString(Name, null, port, ConnectedDevices[port].Name, package);

				  Logger.WriteLine(stage);
				  package.AddStage(stage);

				  ConnectedDevices[port].ReceivePacakge(package, this);

				  timer.Stop();

			  });

			timer.Start();

			
		}

		//Переводит состояние трассировки в строку
		public static string TraceToString(string sender_name, IPAddressWithMask sender_ip, int sender_port, string receiver_name, Package package)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(sender_name).Append(" (");

			if (sender_ip != null)
				sb.Append(sender_ip);

			sb.Append(":").Append(sender_port).Append(") ")
				.Append("sent packet ")
				.Append(package)
				.Append(" to ")
				.Append(receiver_name);

			return sb.ToString();
		}


		/////////////////////////////////////////////////////////////////////////////////////////////////
		/// ГРАФОН
		/////////////////////////////////////////////////////////////////////////////////////////////////

		


	}
}
