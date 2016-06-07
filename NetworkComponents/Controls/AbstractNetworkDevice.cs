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
		/// <summary>
		/// Задержка перед отправкой пакета (графона ради)
		/// </summary>
		public static uint SendingDrawDelay { get; set; }

		/// <summary>
		/// Объект, к которому прикреплены комопненты
		/// Костыль, да.
		/// 
		/// Но Parent не работает для ПК в ГруппахПК
		/// </summary>
		public static NetDrawer Drawer { get; set; }

		/// <summary>
		/// Используется для перемещения контрола
		/// </summary>
		public Mover Mover { get; private set; }

		/// <summary>
		/// Колисчество интерфейсов
		/// </summary>
		public virtual int InterfacesCount { get; private set; }

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


		//Список подключенных устройств
		//Ключ - номер порта, к которому подключено устройство
		protected Dictionary<int, AbstractNetworkDevice> ConnectedDevices { get; set; }


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

        //Отображает интерфейсы на форме
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


        /// <summary>
        /// Возвращает контрол этого объекта.
        /// Костыль, чтобы ПК мог нормально работать в PCGroup
        /// </summary>
        /// <returns></returns>
        public virtual Control GetControl()
        {
            return this;
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

            //Логгирование маршрутов пакетов
            PackageManager.AddPackage(package);

            String stage;
            if (InterfaceAdresses != null)
                stage = TraceToString(Name, InterfaceAdresses[port], port, ConnectedDevices[port].Name, package);
            else
                stage = TraceToString(Name, null, port, ConnectedDevices[port].Name, package);

            Logger.WriteLine(stage);
            package.AddStage(stage);

			if (SendingDrawDelay == 0)
				_send(port, package);
			else
			{
				//Используется таймер с задержкй
				var timer = new System.Timers.Timer(SendingDrawDelay);
				timer.Elapsed += new System.Timers.ElapsedEventHandler(delegate (object sender, ElapsedEventArgs args)
				  {
					  _send(port, package);
					  timer.Stop();

				  });

				//Сообщаем подложке, что надо начать рисовать графон
                if (Drawer is NetDrawer)
                    DrawPackage(port);

				timer.Start();

			}
		}

        /// <summary>
        /// Позволяет переопределить параметры, передаваемые для отрисовки
        /// </summary>
        /// <param name="port"></param>
        public virtual void DrawPackage(int port)
        {
            Drawer.DrawPackage(this.GetControl(), ConnectedDevices[port].GetControl(), SendingDrawDelay);
        }

		private void _send(int port, Package package)
		{
			ConnectedDevices[port].ReceivePacakge(package, this);
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
