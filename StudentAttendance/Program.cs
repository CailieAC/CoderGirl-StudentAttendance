using System;
using System.Collections.Generic;
using System.IO;

namespace StudentAttendance
{
    public class Program
    {
        public static void Main()
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }
        private void Run()
        {
            //The program should print out the names of students that have more than six quiz scores.
            List<Student> studentList = CreateStudentList();
            foreach (var student in studentList)
            {
                if (student.HasSixOrMore())
                {
                    Console.WriteLine($"{student.Name}");
                }
            }
            Console.ReadLine();
        }

        private List<Student> CreateStudentList()
        {
            List<Student> studentList = new List<Student>();

            foreach (string line in File.ReadLines(@"C:\Users\Cailie\Documents\Visual Studio 2017\Projects\CailieAC\CoderGirl-StudentAverage\studentdata.txt"))
            {
                Student student = CreateStudent(line);
                studentList.Add(student);
            }
            return studentList;
        }

        private Student CreateStudent(string line)
        {
            Student student = new Student();
            string[] properties = line.Split(" ");
            int[] scores = new int[properties.Length - 1];
            student.Name = properties[0];

            for (int i = 0; i < properties.Length - 1; i++)
            {
                scores[i] = int.Parse(properties[i + 1]);
            }
            student.Scores = scores;
            return student;
        }
    }
}