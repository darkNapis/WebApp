using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IUsersInRolesService
    {
        List<UserInRole> Get();
        UserInRole Get(int id);
        UserInRole Add(UserInRole userInRoles);
        UserInRole Update(UserInRole userInRoles);
        bool Delete(int id);
    }
}
