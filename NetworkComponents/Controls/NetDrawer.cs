using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkComponents.Controls
{
	/// <summary>
	/// Подложка для компонентов сети
	/// Нарисует линии между ними
	/// </summary>
	public partial class NetDrawer : Panel
	{
		private Dictionary<AbstractNetworkDevice, List<AbstractNetworkDevice>> connections;

		public NetDrawer()
		{
			InitializeComponent();
			connections = new Dictionary<AbstractNetworkDevice, List<AbstractNetworkDevice>>();
		}

		public void Init()
		{
			foreach (var control in Controls)
			{
				var device = (AbstractNetworkDevice)control;
				device.DeviceMove += Device_DeviceMove; ;
			}
		}

		private void Device_DeviceMove(Point arg1, AbstractNetworkDevice arg2)
		{
			Invalidate();
		}
		

		/// <summary>
		/// Заставляет  объект обновить информацию о подключениях
		/// сетевых устройств
		/// 
		/// Дело в том, что обновление - довольно ресурсоемкая процедура, чтобы
		/// делать ее в OnPaint
		/// </summary>
		public void UpdateConnections()
		{
			connections.Clear();

			/*
			 * Каждое устройство возращает readonly 
			 * словарь подключений: порт-устройство
			 * 
			 * Порты нас не интересуют, поэтому все преобразуем к виду:
			 * устройство-список устройств
			 */

			foreach (var control in Controls)
			{
				var device = (AbstractNetworkDevice)control;
				var connections = device.Connections;
				var list = new List<AbstractNetworkDevice>();

				foreach (var connection in connections)
					list.Add(connection.Value);

				this.connections.Add(device, list);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{

			base.OnPaint(e);
			foreach(var device in connections)
			{
				Point d_p = new Point(device.Key.Left + device.Key.Width/2, device.Key.Top+device.Key.Height/2);


				foreach(var connected_device in device.Value)
				{
					Point c_d_p = new Point(connected_device.Left+connected_device.Width/2, connected_device.Top+connected_device.Height/2);
					e.Graphics.DrawLine(Pens.Black, d_p, c_d_p);
				}
			}
		}
	}
}
