using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("controller")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService email)
        {
            _emailService = email;
        }

        [HttpGet]
        public List<Emails> Get()
        {
            return _emailService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Emails Get(int id)
        {
            return _emailService.Get(id);
        }


        [HttpPost]
        [Route("add")]
        public Emails Add(Emails model)
        {
            return _emailService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public Emails Update(Emails email)
        {
            return _emailService.Update(email);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _emailService.Delete(id);
        }
    }
}
