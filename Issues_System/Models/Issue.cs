using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issues_System.Models
{
    class Issue
    {
        public int IssueId { get; set; }
        public string Line { get; set; }
        public string Equipment { get; set; }
        public string IssueDetails { get; set; }
        public TimeSpan IssueTime { get; set; }
    }
}
