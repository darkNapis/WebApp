using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IUserService
    {
        List<Users> Get();
        Users Get(int id);
        Users Add(Users users);
        Users Update(Users users);
        bool Delete(int id);

    }
}
