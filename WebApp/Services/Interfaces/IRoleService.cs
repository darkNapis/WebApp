using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IRoleService
    {
        List<Role> Get();
        Role Get(int id);
        Role AddUserRoles(int id, Role role);
        Role Update(Role roles);
        bool RemoveUserRole(int id, Role role);
        //bool CheckUserRole(int id, Role role);
    }
}
