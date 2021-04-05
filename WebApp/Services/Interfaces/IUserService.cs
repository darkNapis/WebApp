using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IUserService
    {
        List<Users> GetAll();
        Users Details(int id);
        List<Users> GetAllPaginated(int numberPerPage, int offSet);
        Users Add(Users users);
        Users Update(Users users);
        bool Delete(int id);
        bool DeleteBatch(int id);
    }
}
