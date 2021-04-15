using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IUserService
    {
        Users Details(int id);
        List<Users> GetAll();   
        Task<List<Users>> GetAllPaginated(int offSet, int numberPerPage);
        Users Create(Users users);
        Users Update(Users users);
        bool Delete(int id);
        Users DeleteBatch(Users users);
        int CheckUser(int id);
        bool CheckUserName(Users userName);
        bool CheckEmail(Emails emails);
    }
}
