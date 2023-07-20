using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CTest.Models
{
    public class Student_Course_Result
    {
        [Key]
        [Required]
        public int Student_Course_ResultId { get; set; }
        [Required]
        public virtual int StudentId{ get; set; }
        [ForeignKey("StudentId")]
        public virtual List<Student> Students { get; set; }
        [Required]
        public virtual int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual List<Course> Courses { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Enter Score between 0 to 100")]
        public int Score { get; set; }





    }
}