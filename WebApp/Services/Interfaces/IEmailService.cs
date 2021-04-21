using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IEmailService
    {

        List<Email> GetAll();
        Email Details(int id);
        Email Create(Email emails);
        Email Update(Email emails);
        bool Delete(int id);
    }
}
