using System;

namespace Task1.AllPropertiesDateTime
{
/*
 * 
 * С помощью рефлексии выведите все свойства структуры DateTime
 * 
 * Выполнил: Касимовский Андрей
 * 
 */
	class Program
	{
		static void Main(string[] args)
		{
			var propertyInfo = Type.GetType("System.DateTime").GetProperties();
			for(int i = 0; i < propertyInfo.Length; i++)
			{
				Console.WriteLine(propertyInfo[i].ToString());
			}

			Console.ReadKey();
		}
	}
}
