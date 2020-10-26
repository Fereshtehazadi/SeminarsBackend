using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarie.ViewModels
{
    public class VisitorViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string company { get; set; }

        public int seminarId { get; set; }
    }
}
