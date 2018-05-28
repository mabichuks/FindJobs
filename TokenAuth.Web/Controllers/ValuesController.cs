using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenAuth.Web.Models;
using TokenAuth.Web.Repositories;

namespace TokenAuth.Web.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class ValuesController : ApiController
    {
        public UserRepository<ApplicationDbContext> Repo { get; }

        public ValuesController()
        {
            this.Repo = new UserRepository<ApplicationDbContext>();
        }
       
        public IEnumerable<ApplicationUser> Get()
        {
            return Repo.GetUsers();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
