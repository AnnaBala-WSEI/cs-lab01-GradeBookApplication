using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook 
    {
        public new string Name { get; set; }

        public StandardGradeBook(string name) : base(name)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }
    }
}
