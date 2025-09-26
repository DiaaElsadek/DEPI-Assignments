﻿using System.ComponentModel.DataAnnotations;

namespace Assignment_Day03.Models
{
    public class StuCrsRes
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public decimal Grade { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
