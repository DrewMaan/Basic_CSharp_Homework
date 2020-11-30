using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1.ValidLogin
{
	/*
	 * 
	 * б) с использованием регулярных выражений.
	 * 
	 */
	class LoginRegEx
	{
		public string Login { get; set; }
		private Regex regex = new Regex("^[A-Za-z]{1}[A-Za-z0-9]{1,9}$");
		public void CheckLogin()
		{
			if (regex.IsMatch(Login)) Console.WriteLine("Login OK!");
			else Console.WriteLine("Invalid login!");
		}
	}
}
