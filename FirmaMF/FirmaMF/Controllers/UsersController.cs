using FirmaMF.DataAccess;
using FirmaMF.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace FirmaMF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IRepository<User> usersRepository;

        public UsersController(IRepository<User> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<User> GetAllUsers() => this.usersRepository.GetAll();
    }
}
