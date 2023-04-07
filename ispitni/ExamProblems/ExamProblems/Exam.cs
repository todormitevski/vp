using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblems
{
    public class Exam
    {
        public string Month { get; set; }
        public int Year { get; set; }
        public Question Q1 { get; set; }
        public Question Q2 { get; set; }
        public Exam(string month, int year)
        {
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Month} - {Year}";
        }
    }
}
