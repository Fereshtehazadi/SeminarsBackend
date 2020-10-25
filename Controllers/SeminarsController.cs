using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Seminarie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarsController : ControllerBase
    {
        // GET: api/<SeminarsController>
        [HttpGet]
        public IEnumerable<Seminar> Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var seminars = context.Seminars.Include(s => s.visitors).ToArray();
                return seminars;
                   
            }
        }

        // GET api/<SeminarsController>/5
        [HttpGet("{id}")]
        public Seminar Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                //var seminar = context.Seminars.Find(id);

                var seminar = context.Seminars
                           .Where(s => s.id == id)
                           .Include(s => s.visitors)
                           .FirstOrDefault();


                return seminar;

            }
               
            
        }

        // POST api/<SeminarsController>
        [HttpPost]
        public void Post([FromBody] SeminarViewModel seminarVM)
        {
            using (var context = new ApplicationDbContext())
            {
                var seminar = new Seminar { date = seminarVM.date, 
                                             name = seminarVM.name,
                                            description = seminarVM.description, 
                                             maxantal = seminarVM.maxantal,
                                             plats = seminarVM.plats };
                context.Seminars.Add(seminar);
                context.SaveChanges();

            }

        }

        // PUT api/<SeminarsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SeminarsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var seminar = context.Seminars.Find(id);
                context.Seminars.Remove(seminar);
                context.SaveChanges();


               
            }
        }
    }
}
