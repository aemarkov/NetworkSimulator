using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	/// <summary>
	/// Запись табдитцы маршрутизации
	/// </summary>
	public class Route
	{
		public System.Net.IPAddress Destination { get; set; }
		public System.Net.IPAddress Mask { get; set; }
		public System.Net.IPAddress NextRouter { get; set; }
		public int PortNo { get; set; }


		public static Route Parse(string str)
		{
			string[] strs = str.Split(';');
			if (strs.Length != 4)
				throw new ArgumentException("Route must contains DestinationIP, Mask, NextRouter, Port");
			
			Route route = new Route();

			strs[0] = strs[0].Trim();
			if (strs[0] != "default")
			{
				route.Destination = IPAddress.Parse(strs[0]);

				strs[1] = strs[1].Trim();
				route.Mask = IPAddress.Parse(strs[1]);
			}
			
			strs[2] = strs[2].Trim();
			if(strs[2]!="-")
				route.NextRouter = IPAddress.Parse(strs[2]);

			route.PortNo = int.Parse(strs[3]);

			return route;
		}
	}
}
