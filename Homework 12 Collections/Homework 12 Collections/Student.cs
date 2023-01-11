using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_12_Collections
{
    internal class Student
    {
        private static int _noCounter;
        public int No;
        public string FullName;
        public string GroupNo;


        static Student()
        {
            _noCounter = 100;
        }

        public Student(string fullname, string groupNo)
        {
            this.FullName = fullname;
            this.GroupNo = groupNo;
            _noCounter++;
            No = _noCounter;
        }
    }
}
