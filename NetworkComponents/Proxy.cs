using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

		public static List<Proxy> Parse(string str)
		{
			string[] strings = str.Split(';');
			if (strings.Length != 3)
				throw new ArgumentException("Proxy table line must contains SenderIP, ReceiverIP and IsPass");

            List<Proxy> arr = new List<Proxy>();
            bool is_pass;
            IEnumerable<IPAddress> source_ip=null, dest_ip=null;

			strings[0] = strings[0].Trim();
			if (strings[0]!="any")
				//proxy.SenderAdress = System.Net.IPAddress.Parse(strings[0]);
                source_ip = get_range(strings[0]);

			strings[1] = strings[1].Trim();
            if (strings[1] != "any")
                dest_ip = get_range(strings[1]);

			strings[2] = strings[2].Trim();
			is_pass = strings[2] == "pass";

            //Генерим комбинации
            if(source_ip==null && dest_ip!=null)
            {
                foreach(var dest in dest_ip)
                {
                    var proxy = new Proxy();
                    proxy.IsPass = is_pass;
                    proxy.ReceiverAdress = dest;
                    arr.Add(proxy);
                }
            }
            else if(source_ip!=null && dest_ip==null)
            {
                foreach (var source in source_ip)
                {
                    var proxy = new Proxy();
                    proxy.IsPass = is_pass;
                    proxy.SenderAdress = source;
                    arr.Add(proxy);
                }
            }
            else if(source_ip!=null && dest_ip!=null)
            {

                foreach(var source in source_ip)
                {
                    foreach(var dest in dest_ip)
                    {
                        var proxy = new Proxy();
                        proxy.IsPass = is_pass;
                        proxy.SenderAdress = source;
                        proxy.ReceiverAdress = dest;
                        arr.Add(proxy);
                    }
                }
            }
            else
            {
                var proxy = new Proxy();
                proxy.IsPass = is_pass;
                arr.Add(proxy);
            }

			return arr;
		}

        private static IEnumerable<IPAddress> get_range(string str)
        {

            if (!str.Contains('-'))
                return new List<IPAddress>() {IPAddress.Parse(str) };
            else
            {
                //Несколько записей
                int index = str.IndexOf('-');
                var start_str = str.Substring(0, index);
                var end_str = str.Substring(index+1);

                var tool = new IPAddressTools.RangeFinder();
                return tool.GetIPRange(IPAddress.Parse(start_str), IPAddress.Parse(end_str));
            }
        }

        private static object List<T1>()
        {
            throw new NotImplementedException();
        }
	}
}
