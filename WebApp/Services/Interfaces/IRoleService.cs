using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    interface IRoleService
    {
        List<Roles> Get();
        Roles Get(int id);
        Roles Add(Roles roles);
        Roles Update(Roles roles);
        bool Delete(int id);
    }
}
