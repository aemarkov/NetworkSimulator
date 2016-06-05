using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	/// <summary>
	/// Строка прокси-таблицы
	/// </summary>
	class Proxy
	{
		/// <summary>
		/// Адрес источника (null - any)
		/// </summary>
		public System.Net.IPAddress SenderAdress { get; set; }

		/// <summary>
		/// Адрес получателя (null - any)
		/// </summary>
		public System.Net.IPAddress ReceiverAdress { get; set; }
		public bool IsPass { get; set; }

		public static Proxy Parse(string str)
		{
			string[] strings = str.Split(';');
			if (strings.Length != 3)
				throw new ArgumentException("Proxy table line must contains SenderIP, ReceiverIP and IsPass");

			var proxy = new Proxy();

			strings[0] = strings[0].Trim();
			if (strings[0]!="any")
				proxy.SenderAdress = System.Net.IPAddress.Parse(strings[0]);

			strings[1] = strings[1].Trim();
			if (strings[1] !="any")
				proxy.ReceiverAdress = System.Net.IPAddress.Parse(strings[1]);

			strings[2] = strings[2].Trim();
			proxy.IsPass = strings[2] == "pass";

			return proxy;
		}
	}
}
