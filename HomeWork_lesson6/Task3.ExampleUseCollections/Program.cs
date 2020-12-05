using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ExampleUseCollections
{
	/*
	 * 
	 * Переделать программу «Пример использования коллекций» для решения следующих задач:
	 *
	 *	а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
	 *	б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
	 *	в) отсортировать список по возрасту студента;
	 *	г) *отсортировать список по курсу и возрасту студента;
	 *	д) разработать единый метод подсчета количества студентов по различным параметрам
	 *	выбора с помощью делегата и методов предикатов.
	 * 
	 * Выполнил: Касимовский Андрей
	 * 
	 */
	public delegate string Fun1(List<Student> students, int x, out int count);
	public delegate string Fun2(List<Student> students, string str, out int count);

	class Program
	{
		public static int CompareName(Student st1, Student st2)
		{
			return string.Compare(st1.FirstName, st2.FirstName);
		}

		public static int CompareAge(Student st1, Student st2)
		{
			if (st1.Age < st2.Age) return -1;
			else if (st1.Age > st2.Age) return 1;
			else return 0;
		}

		public static int CompareCourseAndAge(Student st1, Student st2)
		{
			if (st1.Course < st2.Course) return -1;
			else if (st1.Course > st2.Course) return 1;
			else
			{
				if (st1.Age < st2.Age) return -1;
				else if (st1.Age > st2.Age) return 1;
				else return 0;
			}
		}

		static void Main(string[] args)
		{
			int numOfBachelors = 0;
			int numOfMasters = 0;

			List<Student> list = new List<Student>();
			DateTime dt = DateTime.Now;
			StreamReader sr = new StreamReader(@"../../students.csv");

			while (!sr.EndOfStream)
			{
				try
				{
					string[] s = sr.ReadLine().Split(';');
					list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
					if (int.Parse(s[5]) < 5) numOfBachelors++;
					else numOfMasters++;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine("Ошибка! ESC - прекратить выполнение программы");

					if (Console.ReadKey().Key == ConsoleKey.Escape) return;
				}
			}

			sr.Close();
			list.Sort(new Comparison<Student>(CompareName));
			Console.WriteLine($"All students numbers: {list.Count}");
			Console.WriteLine($"Students have of master degree: {numOfMasters}");
			Console.WriteLine($"Students have of bachelor degree: {numOfBachelors}");
			foreach (var student in list) Console.WriteLine(student.FirstName + " " + student.LastName);
			NumberOFStudentsFrom18To20(list);
			NumberOFStudentsIn5And6Course(list);
			CountStudents(list, CountByUniversity, "МАИ");
			CountStudents(list, CountByAge, 24);
			Console.WriteLine(DateTime.Now - dt);
			Console.ReadKey();
		}

		public static void NumberOFStudentsIn5And6Course(List<Student> students)
		{
			int course5 = 0;
			int course6 = 0;
			
			foreach(Student student in students)
			{
				if (student.Course == 5) course5++;
				if (student.Course == 6) course6++;
			}

			Console.WriteLine($"Number of students in 5 course: {course5}");
			Console.WriteLine($"Number of students in 6 course: {course6}");
		}

		public static void NumberOFStudentsFrom18To20(List<Student> students)
		{
			Dictionary<int, int> frequency = new Dictionary<int, int>();

			foreach (Student student in students)
			{
				if (student.Age >= 18 && student.Age <= 20)
				{
					if (frequency.ContainsKey(student.Course)) frequency[student.Course]++;
					else frequency.Add(student.Course, 1);
				}
			}

			foreach(KeyValuePair<int, int> pair in frequency)
			{
				Console.WriteLine($"Course number {pair.Key}: {pair.Value}");
			}
		}

		public static void CountStudents(List<Student> students, Fun1 F, int x)
		{
			int count;
			string typeCount;
			typeCount = F(students, x, out count);
			Console.WriteLine($"Count by {typeCount}: {count}");
		}

		public static void CountStudents(List<Student> students, Fun2 F, string str)
		{
			int count;
			string typeCount;
			typeCount = F(students, str, out count);
			Console.WriteLine($"Count by {typeCount}: {count}");
		}

		public static string CountByName(List<Student> students, string firstname, out int count)
		{
			count = 0;
			foreach(Student student in students)
			{
				if (student.FirstName == firstname) count++;
			}

			return "FirstName";
		}

		public static string CountByLastName(List<Student> students, string lastname, out int count)
		{
			count = 0;
			foreach (Student student in students)
			{
				if (student.LastName == lastname) count++;
			}

			return "LastName";
		}

		public static string CountByUniversity(List<Student> students, string university, out int count)
		{
			count = 0;
			foreach (Student student in students)
			{
				if (student.University == university) count++;
			}

			return "University";
		}

		public static string CountByFaculty(List<Student> students, string faculty, out int count)
		{
			count = 0;
			foreach (Student student in students)
			{
				if (student.Faculty == faculty) count++;
			}

			return "Faculty";
		}

		public static string CountByDepartment(List<Student> students, string department, out int count)
		{
			count = 0;
			foreach (Student student in students)
			{
				if (student.Department == department) count++;
			}

			return "Department";
		}

		public static string CountByCity(List<Student> students, string city, out int count)
		{
			count = 0;
			foreach (Student student in students)
			{
				if (student.City == city) count++;
			}

			return "City";
		}

		public static string CountByAge(List<Student> students, int age, out int count)
		{
			count = 0;
			foreach(Student student in students)
			{
				if (student.Age == age) count++;
			}

			return "Age";
		}

		public static string CountByCourse(List<Student> students, int course, out int count)
		{
			count = 0;
			foreach (Student student in students)
			{
				if (student.Course == course) count++;
			}

			return "Course";
		}

		public static string CountByGroup(List<Student> students, int group, out int count)
		{
			count = 0;
			foreach (Student student in students)
			{
				if (student.Group == group) count++;
			}

			return "Group";
		}
	}
}
