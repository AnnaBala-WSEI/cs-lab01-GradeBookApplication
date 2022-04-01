using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook 
    {
        public new string Name { get; set; }

        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Name = name;
            IsWeighted = isWeighted;
            Type = GradeBookType.Standard;
        }
    }
}
