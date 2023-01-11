using System;
using System.Collections.Generic;

namespace Homework_12_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student std1 = new Student("Maqsud", "P232");
            Student std2 = new Student("Amin", "P232");
            Student std3 = new Student("Tural", "P232");
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);

            foreach (var item in students)
            {
                Console.WriteLine($"Fullname: {item.FullName}  GroupNo: {item.GroupNo}");
            }


            foreach (var item in students)
            {
                Console.WriteLine($"Fullname: {item.FullName}  GroupNo: {item.GroupNo}  {item.No}");
            }

            Console.WriteLine("Silmek istediyiniz telebenin nomresini daxil edin");
            var noStr = Console.ReadLine();
            int no = Convert.ToInt32(noStr);

            Student student1= FindStudentByNo(no, students);
            if (student1 == null)
            {
                Console.WriteLine("Bele bir student yoxdur!");
            }
            else
            {
                students.Remove(student1);
                foreach(var student in students)
                {
                    Console.WriteLine($"{student.No}-{student.FullName}-{student.GroupNo}");
                }
            }

        }

        static Student FindStudentByNo(int no, List<Student> studentsArr)
        {
            foreach (var student in studentsArr)
            {
                if (student.No == no)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
