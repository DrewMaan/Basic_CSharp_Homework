using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ValidLogin
{
	/*
	 * 
	 *  Создать программу, которая будет проверять корректность ввода логина. 
	 *  Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
	 *  при этом цифра не может быть первой.
	 *  
	 *  Выполнил: Касимовский Андрей
	 *  
	 */
	class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			//A
			MyLogin myLogin = new MyLogin();
			//B
			LoginRegEx loginRegEx = new LoginRegEx();

			while (count < 5)
			{
				myLogin.Login = Console.ReadLine();
				myLogin.CheckLogin();
				count++;
			}

			count = 0;
			while (count < 5)
			{
				loginRegEx.Login = Console.ReadLine();
				loginRegEx.CheckLogin();
				count++;
			}

			Console.ReadKey();
		}
	}
}
