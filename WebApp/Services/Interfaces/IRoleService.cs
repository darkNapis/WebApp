using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IRoleService
    {
        List<Role> Get();
        Role Get(int id);
        Role AddUserRoles(Role roles, int id);
        Role Update(Role roles);
        bool RemoveUserRole(Role roles, int id);
    }
}
