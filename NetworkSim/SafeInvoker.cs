using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSim
{
	public static class ISynchronizeInvokeExtensions
	{
		/// <summary>
		/// Этот класс используется для безопасного вызова UI методов из другого потока
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_this"></param>
		/// <param name="action"></param>
		public static void InvokeEx<T>(this T _this, Action<T> action) where T : ISynchronizeInvoke
		{
			if (_this.InvokeRequired)
			{
				_this.Invoke(action, new object[] { _this });
			}
			else
			{
				action(_this);
			}
		}
	}
}
