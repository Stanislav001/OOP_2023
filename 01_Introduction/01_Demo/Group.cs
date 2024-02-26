using System;
namespace _01_Demo
{
	public class Group
	{
        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Student> Students { get; set; }

        public Group(string name)
		{
            Name = name;
            Capacity = 10;
            Students = new List<Student>();
		}

        public void AddStudent()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter second name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter id: ");
            string id = Console.ReadLine();

            Student student = new Student(firstName, lastName, id);

            Students.Add(student);
            Console.WriteLine("Success addded new student");
        }

        public void GetInformation()
        {
            Console.WriteLine();
            Console.WriteLine($"Group name: {Name}, capacity: {Capacity}");

            Console.WriteLine("Students: ");
            foreach (Student student in Students)
            {
                student.Introduce();
            }
        }
    }
}

