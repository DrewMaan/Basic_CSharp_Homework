using System;

namespace Task1.AllPropertiesDateTime
{
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
