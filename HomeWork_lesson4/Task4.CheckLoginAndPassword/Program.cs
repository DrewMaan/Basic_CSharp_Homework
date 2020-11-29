using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.CheckLoginAndPassword
{
	struct Account
	{
		public string Login;
		public string Password;
	}
	class Program
	{
		static void Main(string[] args)
		{
			Account[] accounts;
			int tryCount = 0;
			bool check = false;


			accounts = ReadLoginsAndPasswords(@"D:\Learning\GeekBrains_C#\Basic_CSharp\Basic_CSharp_Homework\HomeWork_lesson4\Task4.CheckLoginAndPassword\Accounts.txt");

			if(accounts != null)
			{
				while(tryCount < accounts.Length)
				{
					check = CheckLoginAndPassword(accounts[tryCount]);
					if(check)
					{
						Console.WriteLine("Correctly");
						break;
					}
					else
					{
						Console.WriteLine("Wrong login or password");
					}
					tryCount++;
				}

				Console.WriteLine(check ? "Welcome! You Entered!" : "You've used every attempt");
			}

			Console.ReadKey();
		}

		static bool CheckLoginAndPassword(Account account)
		{
			string l = "root";
			string p = "GeekBrains";

			if (account.Login.Equals(l) && account.Password.Equals(p)) return true;
			else return false;
		}

		static Account[] ReadLoginsAndPasswords(string filename)
		{
			Account[] accounts;
			if (File.Exists(filename))
			{
				string[] ss = File.ReadAllLines(filename);
				accounts = new Account[ss.Length / 2];
				for (int i = 0; i < accounts.Length; i++)
				{
					accounts[i] = new Account { Login = ss[i * 2], Password = ss[i * 2 + 1] };
				}
				return accounts;
			}
			else
			{
				Console.WriteLine("Error load file");
				return null;
			}
		}
	}
}
