using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	/// <summary>
	/// Используется для логгирования
	/// </summary>
	public static class Logger
	{
		public static event Action<String> TextWrited;

		public static void WriteLine(string str)
		{
			Debug.WriteLine(str);
			if (TextWrited != null)
				TextWrited(str + Environment.NewLine);
		}
	}
}
