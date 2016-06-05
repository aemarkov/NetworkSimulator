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
		private Dictionary<UserControl, List<UserControl>> connections;

		public NetDrawer()
		{
			InitializeComponent();
			connections = new Dictionary<UserControl, List<UserControl>>();
		}

		public void Init()
		{
			foreach (var control in Controls)
			{
				if (control is IMovable)
				{
					var device = (IMovable)control;
					device.Mover.DeviceMove += Device_DeviceMove; ;
				}
			}
		}

		private void Device_DeviceMove(Point arg1, UserControl arg2)
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
				if (control is AbstractNetworkDevice)
					//Просто устрйоство
					make_connections((AbstractNetworkDevice)control);
				else if(control is PCGroup)
				{
					//Группа пекарен
					var group = (PCGroup)control;
					/*foreach (var pc in group.pcs)
						make_connections(pc);*/

					var connected = group.pcs.First().Connections.First().Value;
					connections.Add(group, new List<UserControl>() {connected});
				}
				
			}
		}

		private void make_connections(AbstractNetworkDevice device)
		{
			var connections = device.Connections;
			var list = new List<UserControl>();

			foreach (var connection in connections)
				list.Add(connection.Value);

			this.connections.Add(device, list);
		}

		//Рисует
		protected override void OnPaint(PaintEventArgs e)
		{

			base.OnPaint(e);
			foreach(var device in connections)
			{
				Point d_p = new Point(device.Key.Left + device.Key.Width/2, device.Key.Top+device.Key.Height/2);


				foreach(var connected_device in device.Value)
				{
					if (connected_device.Left == -1000) continue;


					Point c_d_p = new Point(connected_device.Left+connected_device.Width/2, connected_device.Top+connected_device.Height/2);
					e.Graphics.DrawLine(Pens.Black, d_p, c_d_p);
				}
			}
		}
	}
}
