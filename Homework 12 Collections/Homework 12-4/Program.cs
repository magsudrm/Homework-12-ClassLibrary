using System;

namespace Homework_12_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1= new Employee();
            emp1.AddAttendance("10-10-2020", false);
            emp1.AddAttendance("10-11-2020", true);
            emp1.AddAttendance("11-10-2020", false);
            emp1.AddAttendance("08-10-2020", true);
            emp1.AddAttendance("10-08-2020", true);
            emp1.AddAttendance("10-09-2020", true);
            emp1.AddAttendance("09-10-2020", true);
            emp1.AddAttendance("07-10-2020", false);
            emp1.AddAttendance("10-07-2020", true);
            emp1.AddAttendance("10-06-2020", false);
            emp1.AddAttendance("06-10-2020", true);
            emp1.AddAttendance("10-05-2020", true);
            emp1.AddAttendance("05-10-2020", true);
            emp1.AddAttendance("10-04-2020", true);
            emp1.AddAttendance("04-10-2020", false);

            foreach (var day in emp1.WorkDays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("Qayib sayi: " + emp1.GetQayibSayi());
            Console.WriteLine("Istirak faizi: " + emp1.GetIstirakFaizi());

        }
    }
}
