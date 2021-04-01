using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    interface IUsersInRolesService
    {

        List<UsersInRoles> Get();
        UsersInRoles Get(int id);
        UsersInRoles Add(UsersInRoles userInRoles);
        UsersInRoles Update(UsersInRoles userInRoles);
        bool Delete(int id);


    }
}
