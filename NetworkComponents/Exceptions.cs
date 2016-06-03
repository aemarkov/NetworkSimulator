using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	//Эксепщены, используемые в здесь

	/// <summary>
	/// Ошибка - сетевое устройство не имеет такого интерфейса
	/// </summary>
	public class NoSuchInterfaceException:Exception
	{
		public NoSuchInterfaceException() : base("Network device hasn't such interface") { }
		public NoSuchInterfaceException(int interface_number) : base("Network device hasn't such interface № " + interface_number) { }
	}

	/// <summary>
	/// К интерфейсу подключено другое сетевое устройство
	/// </summary>
	public class InterfaceAlreadyConnectedException:Exception
	{
		public InterfaceAlreadyConnectedException() : base("This interface already connected to network device") { }
	}
}
