using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook 
    {
        public new string Name { get; set; }

        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Name = name;
            IsWeighted = isWeighted;
            Type = GradeBookType.Ranked;
        }


        public override void CalculateStatistics()
        { 
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            } else
            {
                base.CalculateStatistics();
            }
            
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }

        }

    }
}
