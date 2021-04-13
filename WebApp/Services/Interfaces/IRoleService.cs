using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IRoleService
    {
        List<Roles> Get();
        Roles Get(int id);
        Roles AddUserRoles(Roles roles, int id);
        Roles Update(Roles roles);
        bool RemoveUserRole(Roles roles, int id);
    }
}
