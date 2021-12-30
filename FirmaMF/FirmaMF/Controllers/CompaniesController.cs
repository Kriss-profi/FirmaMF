using FirmaMF.DataAccess;
using FirmaMF.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace FirmaMF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly IRepository<Company> companyRepository;
        public CompaniesController(IRepository<Company> companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Company> GetAllCompanies() => this.companyRepository.GetAll();
    }
}
