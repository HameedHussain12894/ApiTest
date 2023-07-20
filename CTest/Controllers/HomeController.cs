using CTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace CTest.Controllers
{
                                         //Api Testing 
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();
        public ActionResult createstudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult createstudent(Student st)
        {
            //consuming student Api for testing
            client.BaseAddress = new Uri("https://localhost:44371/api/StudentApi");
            var response = client.PostAsJsonAsync<Student>("StudentApi",st);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("www.google.com");
            }

            return View("createstudent");
        }
        [HttpPut]
        public ActionResult editstudent(Student st)
        {
            //consuming student Api for testing
            client.BaseAddress = new Uri("https://localhost:44371/api/StudentApi");
            var response = client.PostAsJsonAsync<Student>("StudentApi", st);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("www.facebook.com");
            }

            return View("editstudent");
        }
    }
}
