using System;

namespace Seminarie.Controllers
{
    public class SeminarViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plats { get; set; }
        public int maxantal { get; set; }
        public DateTime date { get; set; }
    }
}