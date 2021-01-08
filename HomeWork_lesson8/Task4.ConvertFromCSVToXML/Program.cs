using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

/*
 * 
 * *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 * 
 * Выполнил: Касимовский Андрей
 * 
 */

namespace Task4.ConvertFromCSVToXML
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();
			StreamReader streamReader = new StreamReader(@"../../students.csv");
			XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
			Stream fileStream = new FileStream(@"../../students.xml", FileMode.Create, FileAccess.Write);

			while(!streamReader.EndOfStream)
			{
				try
				{
					string[] s = streamReader.ReadLine().Split(';');
					students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine("Ошибка! ESC - прекратить выполнение программы");

					if (Console.ReadKey().Key == ConsoleKey.Escape) return;
				}
			}

			streamReader.Close();
			serializer.Serialize(fileStream, students);
			fileStream.Close();
		}
	}
}
