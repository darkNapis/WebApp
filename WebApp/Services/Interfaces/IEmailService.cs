using System.Collections.Generic;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IEmailService
    {
        List<Email> Get();
        Email Get(int id);
        Email Add(Email emails);
        Email Update(Email emails);
        bool Delete(int id);
    }
}
