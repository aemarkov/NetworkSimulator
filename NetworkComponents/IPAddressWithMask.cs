
using System;
/// <summary>
/// Класс, описывающий адрес интерфейса-маска + адрес
/// </summary>
public class IPAddressWithMask
{
	public System.Net.IPAddress IP { get; set; }
	public System.Net.IPAddress Netmask { get; set; }

	private Int32 ip;
	private Int32 mask;

	public IPAddressWithMask(System.Net.IPAddress ip, System.Net.IPAddress mask)
	{
		IP = ip;
		Netmask = mask;
	}

	/// <summary>
	/// Создает новый IP адрес с маской на основе сокращенной записи
	/// </summary>
	/// <param name="ip_with_mask">Сокращенная запись адреса, например 192.168.1./24</param>
	public IPAddressWithMask(string ip_with_mask)
	{
		if (!ip_with_mask.Contains("/"))
			throw new ArgumentException("String must contains mask (ipadress/mask)");

		string[] parts = ip_with_mask.Split('/');
		IP = System.Net.IPAddress.Parse(parts[0]);

		//Преобразование кол-ва бит в массив байт адреса с нужным числом бит
		byte[] mask = new byte[4];
		int one = 128;
		for (int i = 0; i< int.Parse(parts[1]); i++)
		{
			int index = i / 8;
			mask[index] |= (byte)one;
			one >>= 1;
			if (one == 0)
				one = 128;
		}

		//Netmask = System.Net.IPAddress.Parse("255.255.255.128");
		Netmask = new System.Net.IPAddress(mask);
		string test = Netmask.ToString();
	}

	//localhost по-умолчанию
	//В программе локалхост не используется, и по смыслу
	//не отличается от пустых строк
	public IPAddressWithMask()
	{
		IP = System.Net.IPAddress.Parse("127.0.0.1");
		Netmask = System.Net.IPAddress.Parse("255.0.0.0");

		//IP = new System.Net.IPAddress(0);
		//Netmask = new System.Net.IPAddress(0);
	}


	/// <summary>
	/// Определяет адрес подсети хоста
	/// </summary>
	/// <param name="host_ip">Адрес хоста</param>
	/// <param name="netmask">Маска подсети</param>
	/// <returns></returns>
	public static System.Net.IPAddress GetNetworkAdress(System.Net.IPAddress host_ip, System.Net.IPAddress netmask)
	{
		byte[] host_bytes = host_ip.GetAddressBytes();
		byte[] netmask_bytes = netmask.GetAddressBytes();

		if(host_bytes.Length!=netmask_bytes.Length)
			throw new ArgumentException("Lengths of IP address and subnet mask do not match");

		byte[] network_byte = new byte[host_bytes.Length];

		for (int i = 0; i < host_bytes.Length; i++)
			network_byte[i] = (byte)(host_bytes[i] & netmask_bytes[i]);

		return new System.Net.IPAddress(network_byte);

	}

	/// <summary>
	/// Определяет, находятся ли два адреса в разных подсетях
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <param name="netmask"></param>
	/// <returns></returns>
	public static bool IsInSameSubnet(System.Net.IPAddress a, System.Net.IPAddress b, System.Net.IPAddress netmask)
	{
		System.Net.IPAddress aa = GetNetworkAdress(a, netmask);
		System.Net.IPAddress bb = GetNetworkAdress(b, netmask);
		return GetNetworkAdress(a, netmask).Equals(GetNetworkAdress(b, netmask));
	}

	/// <summary>
	/// Определяет, находятся ли два адреса в разных подсетях
	/// </summary>
	/// <param name="other"></param>
	/// <returns></returns>
	public bool IsInSameSubnet(System.Net.IPAddress other)
	{
		return IsInSameSubnet(IP, other, Netmask);
	}

	public override string ToString()
	{
		return IP.ToString() + "/" + mask_to_short_form(Netmask);
	}


	//Возвращает число единичных бит в маске
	private int mask_to_short_form(System.Net.IPAddress mask)
	{
		byte[] bytes = mask.GetAddressBytes();
		int number_of_bits = 0; 
		foreach(var _octet in bytes)
		{
			byte octet = _octet;

			while (octet != 0)
			{
				number_of_bits += octet & 1;
				octet >>= 1;
			}
		}

		return number_of_bits;
	}
}