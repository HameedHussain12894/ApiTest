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
    public class StudentApiController : ApiController
    {
        db_operations db = new db_operations();
        [HttpPost]
        public IHttpActionResult StudentAdd(Student student)
        {
            db.students.Add(student);
            db.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Studentupdate(Student student)
        {
            db.Entry(student).State=EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }


    }
}
