using CTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CTest.Controllers
{
    public class CourseApiController : ApiController
    {

        db_operations db = new db_operations();
        [HttpPost]
        public IHttpActionResult CourseAdd(Course course)
        {
            db.courses.Add(course);
            db.SaveChanges();
            return Ok();
        }
    }
}
