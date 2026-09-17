using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStructures26E
{
    public class Student
    {
        public string Name { get; set; }
        public int? TestScore { get; set; }
        public Student(string name)
        {
            Name = name;
            TestScore = null;
        }
    }
}
