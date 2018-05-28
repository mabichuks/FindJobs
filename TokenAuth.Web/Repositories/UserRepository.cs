using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TokenAuth.Web.Models;

namespace TokenAuth.Web.Repositories
{
    public class UserRepository<C>: IUserRepository where C: DbContext
    {
        private ApplicationDbContext ctxt;
        public UserRepository()
        {
            this.ctxt = new ApplicationDbContext();
        }
        public IEnumerable<ApplicationUser> GetUsers()
        {
            return ctxt.Users.ToList();
        }
    }
}