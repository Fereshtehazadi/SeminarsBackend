using System;
using System.Collections.Generic;

namespace Seminarie
{
    public class Seminar
    {
        public int id { get; set;}
        public string name { get; set;}
        public string description { get; set;}
        public string plats { get; set;}
        public int maxantal { get; set;}
        public DateTime date { get; set;}
        public List<Visitor> visitors { get; set; }

        //Recensioner

    }
}