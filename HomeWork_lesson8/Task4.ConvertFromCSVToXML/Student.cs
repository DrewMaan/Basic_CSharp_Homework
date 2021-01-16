using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.ConvertFromCSVToXML
{
	public class Student
	{
		public string FirstName;
		public string LastName;
		public string University;
		public string Faculty;
		public int Course;
		public string Department;
		public int Group;
		public string City;
		public int Age;

		public Student()
		{

		}

		public Student(string firstname, string lastname, string university, string faculty, string department,
			int age, int course, int group, string city)
		{
			FirstName = firstname;
			LastName = lastname;
			University = university;
			Faculty = faculty;
			Course = course;
			Department = department;
			Group = group;
			City = city;
			Age = age;
		}
	}
}
