﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyRelationship
{
    public class Enrollment
    {
        public Student AStudent { set; get; }
        public Course CourseTaken { set; get; }
        public DateTime EnrolledDate { set; get; }

       // public string StudentName{get { return AStudent.Name; }}

        public override string ToString()
        {
            return EnrolledDate.ToString();
        }
    }
}
