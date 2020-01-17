using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issues_System.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Line { get; set; }
        public string Equipment { get; set; }
        public string Details { get; set; }
        public string Solution { get; set; }
        public TimeSpan OpenAt { get; set; }
        public TimeSpan TimeOpen { get; set; }
        public TimeSpan ClosedAt { get; set; }
        public bool IsClosed { get; set; }
    }
}
