using System;
using System.Collections.Generic;

namespace theGradeBook
{
    class GradeBook
    {
        public GradeBook()
        {

        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;
    }
}
