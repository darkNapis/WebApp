using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService email)
        {
            _emailService = email;
        }

        [HttpGet]
        public List<Email> Get()
        {
            return _emailService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Email Get(int id)
        {
            return _emailService.Get(id);
        }

        [HttpPost]
        [Route("Create")]
        public Email Create(Email model)
        {
            return _emailService.Create(model);
        }

        [HttpPatch]
        [Route("update")]
        public Email Update(Email email)
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
