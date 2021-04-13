using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IUsersInRolesService
    {

        List<UsersInRoles> Get();
        UsersInRoles Get(int id);
        UsersInRoles Add(UsersInRoles userInRoles);
        UsersInRoles Update(UsersInRoles userInRoles);
        bool Delete(int id);


    }
}
