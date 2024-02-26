using System;
namespace _01_Demo
{
	public class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }
		
		public string Id { get; set; }

		public string Address { get; set; }

		public Student()
		{

		}

		public Student(string firstName, string lastName, string id)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Id = id;
		}

		public void Introduce()
		{
			Console.WriteLine($"{FirstName} {LastName}, id: {Id}");
		}
	}
}

