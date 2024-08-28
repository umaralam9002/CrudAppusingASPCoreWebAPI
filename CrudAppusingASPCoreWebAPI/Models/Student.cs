﻿using Microsoft.Build.Framework;

namespace CrudAppusingASPCoreWebAPI.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string studentGender { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int Class { get; set; }
        [Required]
        public string fatherName { get; set; }
    }
}


