using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTest.Models
{
    public class Student
    {
        [Key]
        public int StudentId { set; get; }
        [Required]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets allows")]
        public string Full_Name { set; get; }
    }
}