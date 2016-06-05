using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	/// <summary>
	/// Сохраняет все пакеты
	/// </summary>
	public static class PackageManager
	{
		public static event Action<Package> NewPackage;
		public static int id = 0;

		static List<Package> packages = new List<Package>();
		public static IReadOnlyList<Package> Pacakges { get { return packages.AsReadOnly(); } }

		public static void Clear()
		{
			packages.Clear();
		}

		/// <summary>
		/// Добавляет пакет в отслаживатель
		/// </summary>
		/// <param name="package">Пакет</param>
		public static void AddPackage(Package package)
		{
			if (!packages.Contains(package))
			{
				packages.Add(package);
				package.ID = id++;
				NewPackage?.Invoke(package);
			}
		}

		/// <summary>
		/// Удаляет все
		/// </summary>
		public static void Reset()
		{
			packages.Clear();
			id = 0;
		}
	}
}
