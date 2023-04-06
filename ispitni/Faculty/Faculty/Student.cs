using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class Student
    {
        public string FullName { get; set; }
        public string Index { get; set; }
        public List<int> Grades { get; set; }

        public Student(string fullName, string index)
        {
            FullName = fullName;
            Index = index;
            Grades = new List<int>();
        }

        public override string ToString()
        {
            return $"{Index} - {FullName}";
        }
    }
}
