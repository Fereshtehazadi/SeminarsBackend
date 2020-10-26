using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Seminarie.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Seminarie.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CORSPolicy")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        // GET: api/<VisitorsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var visitors = context.Set<Visitor>();
                var result = new List<string>();
                foreach (var visitor1 in visitors)
                {
                    result.Add(visitor1.name);
                }
                return result;

            }
        }

        // GET api/<VisitorsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //POST api/<VisitorsController>
        [HttpPost]
        public void Post([FromBody] VisitorViewModel visitorVM)
        {
            using (var context = new ApplicationDbContext())
            { 
                var visitor = new Visitor
                {
                   
                    name = visitorVM.name,
                   email= visitorVM.email,
                    phone = visitorVM.phone,
                    company = visitorVM.company,
                    seminarId= visitorVM.seminarId

                };
                context.Visitors.Add(visitor);                                            

                context.SaveChanges();
            }
        }

        // PUT api/<VisitorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VisitorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    //SeminarId
}
