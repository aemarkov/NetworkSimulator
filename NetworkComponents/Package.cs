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
	public class Package
	{
		/// <summary>
		/// Состояние пакета
		/// </summary>
		public enum State
		{
			SENDING,
			RECEIVED,
			DENIED,
			REJECTED
		}

		public string StartIP { get; set; }
		public string EndIP { get; set; }
		public State PackageState { get; set; }


		public List<AbstractNetworkDevice> Trace { get; }

		

		public Package()
		{
			Trace = new List<AbstractNetworkDevice>();
			PackageState = State.SENDING;
		}

		/// <summary>
		/// Добавляет очередное устройство в машруте
		/// </summary>
		/// <param name="device"></param>
		public void AddStage(AbstractNetworkDevice device)
		{
			Trace.Add(device);
		}

		public override String ToString()
		{
			return "[" + StartIP + "; " + EndIP + "]";
		}
	}
}
