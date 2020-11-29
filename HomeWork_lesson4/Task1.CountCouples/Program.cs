using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.CountCouples
{
	class Program
	{
		/*
		 * 
		 * Дан  целочисленный  массив  из 20 элементов.  
		 * Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
		 * Заполнить случайными числами.  
		 * Написать программу, позволяющую найти и вывести количество пар элементов массива, 
		 * в которых только одно число делится на 3. 
		 * В данной задаче под парой подразумевается два подряд идущих элемента массива. 
		 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
		 * 
		 * Выполнил: Касимовский Андрей
		 * 
		 */
		static void Main(string[] args)
		{
			int[] array = new int[20];
			int count = 0;
			Random random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(-10000, 10000);
			}

			Console.WriteLine("Array:");
			for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
			Console.WriteLine();

			for (int i = 0, j = 1; j < array.Length; i++, j++)
			{
				if (array[i] % 3 == 0)
				{
					if (array[j] % 3 != 0) count++;
				}
				else if (array[j] % 3 == 0) count++;
			}

			Console.WriteLine($"Count couples: {count}");
			Console.ReadKey();
		}
	}
}
