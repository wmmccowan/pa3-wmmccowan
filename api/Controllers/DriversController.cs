using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.DataAccess;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        // GET: api/Drivers
        [HttpGet]
        public List<Drivers> Get()
        {
            DriversDataAccess dataAccess = new DriversDataAccess();
            return dataAccess.GetAll();
        }

        // GET: api/Drivers/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Drivers
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Drivers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Drivers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
