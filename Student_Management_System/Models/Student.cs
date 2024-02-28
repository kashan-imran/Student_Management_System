using System;
using System.Collections.Generic;

namespace Student_Management_System.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Class { get; set; }
        public string Gender { get; set; } = null!;
    }
}
