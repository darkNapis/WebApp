using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IUserService
    {
        User Details(int id);
        List<User> GetAll();
        Task<List<User>> GetAllPaginated(int offSet, int numberPerPage);
        User Create(User users);
        User Update(User users);
        bool Delete(int id);
        User DeleteBatch(User users);
        //int CheckUser(int id);
        bool CheckUserName(User userName);
        bool CheckEmail(Email emails);
    }
}
