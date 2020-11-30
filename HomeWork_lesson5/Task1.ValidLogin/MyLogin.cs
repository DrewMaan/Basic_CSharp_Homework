using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ValidLogin
{
	/*
	 * 
	 * а) без использования регулярных выражений
	 * 
	 */
	class MyLogin
	{
		public string Login { get; set; }

		public void CheckLogin()
		{
			if (Login.Length < 2 || Login.Length > 10)
			{
				Console.WriteLine("Invalid login!");
				return;
			}
			Char[] loginArray = Login.ToCharArray();
			if(!Char.IsDigit(loginArray[0]))
			{
				for(int i = 0; i < loginArray.Length; i++)
				{
					if ((loginArray[i] >= 'a' && loginArray[i] <= 'z') || (loginArray[i] >= 'A' && loginArray[i] <= 'Z') || (loginArray[i] >= '0' && loginArray[i] <= '9'))
					{
						continue;
					}
					else
					{
						Console.WriteLine("Invalid login!");
						return;
					}
				}
			}
			else
			{
				Console.WriteLine("Invalid login!");
				return;
			}

			Console.WriteLine("Login OK!");
		}
	}
}
