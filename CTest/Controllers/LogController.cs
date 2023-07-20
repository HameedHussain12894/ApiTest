using CTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTest.Controllers
{
    public class LogController : Controller
    {
        private readonly SchedulerService _schedulerService;

        public LogController(SchedulerService schedulerService)
        {
            _schedulerService = schedulerService;
        }

        public ActionResult Index()
        {
            var logs = _schedulerService.GetLogs();
            return View(logs);
        }
    }
}