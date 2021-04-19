using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IEmailService
    {
        List<Email> Get();
        Email Get(int id);
        Email Create(Email emails);
        Email Update(Email emails);
        bool Delete(int id);
        Email CheckForEmail(string emailExist);
    }
}
