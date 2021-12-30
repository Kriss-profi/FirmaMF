using FirmaMF.DataAccess;
using FirmaMF.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace FirmaMF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IRepository<Client> clientRepository;

        public ClientsController(IRepository<Client> clientRepository) // Dependency iniection (wstrzykiwanie innych klas przez konstruktor
        {
            this.clientRepository = clientRepository;
        }

        [HttpGet]       // endpoint
        [Route("")]
        public IEnumerable<Client> GetAllClients() => this.clientRepository.GetAll();
    }
}
