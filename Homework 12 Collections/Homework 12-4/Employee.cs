using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_12_4
{
    internal class Employee
    {
        public string FullName;
        Dictionary<string, bool> attendances = new Dictionary<string, bool>();

        public List<string> WorkDays
        {
            get
            {
                List<string> days = new List<string>();
                foreach (var item in attendances)
                    days.Add(item.Key);

                return days;
            }
        }
        public void AddAttendance(string date, bool trueOrFalse)
        {
            if (!attendances.ContainsKey(date))
            {
                attendances.Add(date, trueOrFalse);
            }
        }

        public int GetQayibSayi()
        {
            int count = 0;
            foreach (var item in attendances)
            {
                if (!item.Value)
                {
                    count++;
                }
            }
            return count;
        }

        public double GetIstirakFaizi()
        {
            double result = 100 - (GetQayibSayi() / attendances.Count) * 100;
            return result;
        }
    }
}