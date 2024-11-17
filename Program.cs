using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{


    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }

        public Student(string id, string name, double mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.Write("Enter the number of students (5-10): ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            while (numberOfStudents < 5 || numberOfStudents > 10)
            {
                Console.Write("Invalid number. Enter a number between 5 and 10: ");
                numberOfStudents = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("Enter ID for student {i + 1}: ");
                string id = Console.ReadLine();

                Console.Write("Enter Name for student {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write("Enter Mark for student {i + 1}: ");
                double mark = double.Parse(Console.ReadLine());

                students.Add(new Student(id, name, mark));
            }

            Console.WriteLine("\nStudents who passed:");
            foreach (var student in students)
            {
                if (student.Mark >= 50)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
    }
}


            
        
    

    

       
