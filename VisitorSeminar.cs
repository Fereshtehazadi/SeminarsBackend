using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarie
{
    public class VisitorSeminar
    {
        public int visitorId { get; set; }
        public Visitor visitor { get; set; }

        public int seminarId { get; set; }
        public Seminar seminar { get; set; }
    }
}
