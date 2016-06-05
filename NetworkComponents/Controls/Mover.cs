using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkComponents.Controls
{
	/// <summary>
	/// Реализует события для перетаскивания компонента
	/// </summary>
	public class Mover
	{
		public event Action<Point, UserControl> DeviceMove;


		//Перетаскивание
		private Point previous_point;
		private bool is_drag = false;
		private UserControl device;

		public Mover(UserControl device)
		{
			this.device = device;
			device.MouseDown += Device_MouseDown;
			device.MouseMove += Device_MouseMove;
			device.MouseUp += Device_MouseUp;
			device.MouseLeave += Device_MouseLeave;
		}

		private void Device_MouseLeave(object sender, EventArgs e)
		{
			is_drag = false;
		}

		private void Device_MouseMove(object sender, MouseEventArgs e)
		{
			if (is_drag)
			{
				int delta_x = e.X - previous_point.X;
				int delta_y = e.Y - previous_point.Y;

				device.Left += delta_x;
				device.Top += delta_y;

				DeviceMove?.Invoke(new Point(device.Left, device.Top), device);
			}
		}

		private void Device_MouseUp(object sender, MouseEventArgs e)
		{
			is_drag = false;
		}

		private void Device_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				previous_point = e.Location;
				is_drag = true;
			}
		}
	}
}
