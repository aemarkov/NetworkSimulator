using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	/// <summary>
	/// Простейшая реализация пото-безопасного списка
	/// </summary>
	public class BlockingList<T>
	{
		private List<T> list = new List<T>();
		private object sync = new object();

		public void Add(T value)
		{
			lock(sync)
			{
				list.Add(value);
			}
		}

		public void Clear()
		{
			lock(sync)
			{
				list.Clear();
			}
		}

		public T this[int index]
		{
			get
			{
				lock(sync)
				{
					return list[index];
				}
			}

			set
			{
				lock(sync)
				{
					list[index] = value;
				}
			}
		}

		public int Count
		{
			get
			{
				lock(sync)
				{
					return list.Count;
				}
			}
		}

		public bool Contains(T obj)
		{
			lock(sync)
			{
				return list.Contains(obj);
			}
		}

		public IReadOnlyList<T> AsReadOnly()
		{
			lock(sync)
			{
				return list.AsReadOnly();
			}
		}
	}
}
