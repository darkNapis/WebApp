using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Services.Interfaces
{
    public interface IEmailService
    {

        List<Emails> Get();
        Emails Get(int id);
        Emails Add(Emails emails);
        Emails Update(Emails emails);
        bool Delete(int id);

    }
}
