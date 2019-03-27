using System;
using System.Collections.Generic;
using System.IO;

namespace StudentAttendance
{
    public class Program
    {
        public static void Main()
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

        public static List<Student> CreateStudentList()
        {
            List<Student> studentList = new List<Student>();

            foreach (string line in File.ReadLines(@"studentdata.txt"))
            {
                Student student = CreateStudent(line);
                studentList.Add(student);
            }
            return studentList;
        }

        public static Student CreateStudent(string line)
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