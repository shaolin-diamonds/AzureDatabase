﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Group1A4.Models
{
    public partial class Class
    {
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public string ClassName { get; set; }
        public int InstructorId { get; set; }
        public int ClassCredits { get; set; }

        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}