using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook 
    {
        public new string Name { get; set; }

        public RankedGradeBook(string name) : base(name)
        {
            Name = name;
            Type = GradeBookType.Ranked;
        }


    }
}
