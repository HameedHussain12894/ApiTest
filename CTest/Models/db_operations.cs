using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CTest.Models
{
    public class db_operations: DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }

        public DbSet<Student_Course_Result> students_courses_results { get; set; }



    }
}