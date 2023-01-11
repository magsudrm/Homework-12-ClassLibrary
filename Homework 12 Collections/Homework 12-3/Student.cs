using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_12_3
{
    internal class Student
    {
        public string FullName;
        Dictionary<string, int> _exams = new Dictionary<string, int>();

        public List<string> Subjects
        {
            get
            {
                List<string> list = new List<string>();
                foreach (var item in _exams)
                    list.Add(item.Key);
                return list;
            }
        }

        public int? GetExamResult(string name)
        {
            if (_exams.ContainsKey(name))
            {
                return _exams[name];
            }
            return null;
        }

        public void Add(string name, int point)
        {
            if (!_exams.ContainsKey(name))
                _exams.Add(name, point);
        }

        public int GetAvg()
        {
            int sum = 0;
            int avrg = 0;
            if (_exams.Count > 0)
            {
                foreach (var exam in _exams)
                    sum += exam.Value;

                avrg = sum / _exams.Count;
            }

            return avrg;
        }
    }
}
