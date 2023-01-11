using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework_12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FullName = "Abbas Babazade";
            student1.Add("Design", 56);
            student1.Add("Programming", 100);
            student1.Add("System", 45);
            student1.Add("Marketing", 80);

            foreach(var student in student1.Subjects)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Subject deyerini daxil edin: ");
            string subject = Console.ReadLine();
            var subPoint = student1.GetExamResult(subject);

            if (subPoint == null)
            {
                Console.WriteLine("Axtardiginiz typda subject yoxdur");

            }
            else
            {
                Console.WriteLine(subPoint);
            }

        }
    }
}
