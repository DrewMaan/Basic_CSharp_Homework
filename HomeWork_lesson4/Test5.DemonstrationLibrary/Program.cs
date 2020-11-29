﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.TwoDimensionalArray;

namespace Test5.DemonstrationLibrary
{
	/*
     * 
     * Задача 5 (демонстрация)
     * *а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
     * **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
     * **в) Обработать возможные исключительные ситуации при работе с файлами.
     * 
     * Выполнил: Касимовский Андрей
     * 
     */
	class Program
	{
		static void Main(string[] args)
		{
			ArrayTwoDimensional array = new ArrayTwoDimensional(5, 6);

			Console.WriteLine("Array (created by constractor with random numbers):");
			array.Print();

			Console.WriteLine($"Max element: {array.Max}");
			Console.WriteLine($"Min element: {array.Min}");
			
			int sum = array.SumArray();
			Console.WriteLine($"Sum elements: {sum}");
			sum = array.SumArray(10);
			Console.WriteLine($"Sum elements which are more that 10: {sum}");

			int row;
			int column;
			array.NumberMaxElement(out row, out column);
			Console.WriteLine($"Row and column max element: {row} {column}");

			ArrayTwoDimensional array1 = new ArrayTwoDimensional(@"D:\Learning\GeekBrains_C#\Basic_CSharp\Basic_CSharp_Homework\HomeWork_lesson4\Test5.DemonstrationLibrary\read_array.txt");
			Console.WriteLine("Array (created by constractor with read from file):");
			array1.Print();

			array.WriteArrayFromFile(@"D:\Learning\GeekBrains_C#\Basic_CSharp\Basic_CSharp_Homework\HomeWork_lesson4\Test5.DemonstrationLibrary\write_array.txt");
			Console.ReadKey();
		}
	}
}
