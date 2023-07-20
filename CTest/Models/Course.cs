using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTest.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }   
        [Required]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Name { get; set; }    
    }
}