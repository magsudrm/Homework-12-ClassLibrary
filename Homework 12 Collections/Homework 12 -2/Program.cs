using System;
using System.Collections.Generic;

namespace Homework_12__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> groups = new Dictionary<string, int>();
            groups.Add("D234", 67);
            groups.Add("S11", 87);
            groups.Add("P334", 32);
            groups.Add("P432", 45);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
            }

            Console.Write("GroupNo deyerini daxil edin: ");
            string groupNo = Console.ReadLine();
            if (groups.ContainsKey(groupNo))
            {
                Console.WriteLine(groups[groupNo]);
            }
            else
            {
                Console.WriteLine("Bele bir qrup yoxdur"); ;
            }
        }
    }
}
