using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTest.Models
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
    }
}