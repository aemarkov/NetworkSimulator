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
		//Соединения для отрисовки линий
		private Dictionary<UserControl, List<UserControl>> connections;

		//Для отрисовки движущихся пакетов
		private List<MovingPackage> moving_packages;

		ulong current_time = 0;
		
		public NetDrawer()
		{
			InitializeComponent();
			connections = new Dictionary<UserControl, List<UserControl>>();
			moving_packages = new List<MovingPackage>();
            DoubleBuffered = true;
		}

		/// <summary>
		/// Инициализация.
		/// Обязательно вызвать
		/// </summary>
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

		//Устройство сдвинуто
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

                    if (group.pcs.FirstOrDefault() != null)
                    {
                        var con = group.pcs.FirstOrDefault().Connections;
                        if (con != null && con.Count != 0)
                        {
                            var connected = con.First().Value;
                            connections.Add(group, new List<UserControl>() { connected });
                        }
                    }
				}
				
			}
		}

		//Сохраняет соединения
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
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			
			//Рисование линий
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

			//Рисование пакетов
			for(int i = 0; i<moving_packages.Count;i++)
			{
				if(moving_packages[i].EndTime<current_time)
				{
					moving_packages.RemoveAt(i);
					continue;
				}

				var pos = moving_packages[i].GetPosInTime(current_time);
				e.Graphics.FillEllipse(Brushes.Red, pos.X-10, pos.Y-10, 20, 20);

			}

		}

		/// <summary>
		/// Надо нарисовать движение пакета от одного устройства к
		/// другому за вермя duration
		/// </summary>
		/// <param name="device1"></param>
		/// <param name="device2"></param>
		/// <param name="duration"></param>
		public void DrawPackage(Control device1, Control device2, uint duration)
		{
			var package = new MovingPackage() { color = Color.Red, StartDevice = device1, EndDevice = device2, StartTime = current_time, EndTime = current_time + duration };
			moving_packages.Add(package);
		}

		public void UpdateAnimation(uint dt)
		{
			current_time += dt;
			Invalidate();			
		}
	}


	/// <summary>
	/// Вспомогательный класс для хранения
	/// информации о картинке пакета
	/// </summary>
	class MovingPackage
	{
		public Color color { get; set; }
		public Control EndDevice { get; set; }
		public Control StartDevice { get; set; }
		public ulong StartTime { get; set; }
		public ulong EndTime { get; set; }

		
		public PointF GetDist()
		{
            float dx = EndDevice.Left + EndDevice.Width/2 - (StartDevice.Left+StartDevice.Width/2);
			float dy = EndDevice.Top + EndDevice.Height/2 - (StartDevice.Top+StartDevice.Height/2);
			return new PointF(dx, dy);
		}

		public PointF GetPosInTime(ulong time)
		{
            float dt =  ((float)(time - StartTime)) / (EndTime - StartTime);
			var dist = GetDist();
            dist.X = StartDevice.Left + StartDevice.Width/2 + dist.X * dt; ;
            dist.Y = StartDevice.Top  + StartDevice.Height/2 + dist.Y * dt; ;

			return dist;
		}

		public MovingPackage() { }

		public MovingPackage(AbstractNetworkDevice device1, AbstractNetworkDevice device2, long end_time)
		{
			EndDevice = device2;

		}
	}
}
