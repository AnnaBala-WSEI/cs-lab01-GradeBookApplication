using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5) throw new InvalidOperationException();
            int tweentyProcentCount = (int)Math.Round(Students.Count * 0.2);

            var studentGrades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            for(int i=0; i<studentGrades.Count; i++)
            {
                if(averageGrade == studentGrades[i])
                {

                    if(i<tweentyProcentCount) return 'A';
                    else if  (i<(2 * tweentyProcentCount)) return 'B';
                    else if (i<(3 * tweentyProcentCount)) return 'C';
                    else if (i<(4 * tweentyProcentCount)) return 'D';
                    else if  (i<(5 * tweentyProcentCount)) return 'F';
                }
            }
            return 'F';
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
