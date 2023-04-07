using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblems
{
    public class Question
    {
        public string Description { get; set; }
        public int Points { get; set; }

        public Question(string description, int points)
        {
            Description = description;
            Points = points;
        }
    }
}
