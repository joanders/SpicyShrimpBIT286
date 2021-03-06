﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BIT285_SpicyShrimps.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int StudentID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastInitial { get; set; }
        public string Username { get { return FirstName + ". " + LastInitial; } }
        public int TeacherID { get; set; }
        [Required]
        public string OneWordPassword { get; set; }
        public int Level { get; set; }
        /*Navigation Property for Teacher*/
        public virtual Teacher Teacher { get; set; }
    }
}
