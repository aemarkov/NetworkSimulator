using NetworkComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	/// <summary>
	/// Сетевой пакет
	/// </summary>
	public class Package : ICloneable
	{
		/// <summary>
		/// ID, для идентификации
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Состояние пакета
		/// </summary>
		public enum State
		{
			SENDING,
			RECEIVED,
			DENIED,
			NO_ROUTE,
			REJECTED
		}

		public System.Net.IPAddress StartIP { get; set; }
		public Stack<System.Net.IPAddress> EndIP { get; set; }
		public State PackageState { get; set; }


		public List<String> Trace { get; private set; }

		

		public Package()
		{
			Trace = new List<string>();
			PackageState = State.SENDING;
		}

		/// <summary>
		/// Создает пакет на основе строкоого представления конечного адреса
		/// </summary>
		/// <param name="end_ip"></param>
		public Package(string end_ip):this()
		{
			EndIP = new Stack<System.Net.IPAddress>();
			EndIP.Push(System.Net.IPAddress.Parse(end_ip));
		}

		/// ОТСЛЕЖИВАНИЕ ПУТИ

		/// <summary>
		/// Добавляет очередное устройство в машруте
		/// </summary>
		/// <param name="device"></param>
		public void AddStage(String device)
		{
			Trace.Add(device);
		}

		//Возвращает строкове представление пакета
		public override String ToString()
		{
			return "[#"+ID+"; "+ StartIP + "; " + EndIP.Peek() + "]";
		}

		//Создание копии
		public object Clone()
		{
			Package copy = new Package();
			copy.PackageState = PackageState;
			copy.StartIP = StartIP;
			copy.EndIP = EndIP;
			copy.Trace = Trace.Select(x => x).ToList();
			return copy;
		}
	}
}
