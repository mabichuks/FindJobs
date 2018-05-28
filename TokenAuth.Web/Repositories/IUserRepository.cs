using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenAuth.Web.Models;

namespace TokenAuth.Web.Repositories
{
    interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetUsers();
    }
}
