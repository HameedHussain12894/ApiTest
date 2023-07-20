using CTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace CTest.Controllers
{
    public class Course_Result_ApiController : ApiController
    {
        db_operations db = new db_operations();
        [HttpPost]
        public IHttpActionResult Add_Course_Result(Student_Course_Result course_result)
        {
            db.students_courses_results.Add(course_result);
            db.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Update_Course_Result(Student_Course_Result course_result)
        {
            db.Entry(course_result).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }
    }
}
