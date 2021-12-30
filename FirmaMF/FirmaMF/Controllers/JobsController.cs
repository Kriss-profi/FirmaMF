using FirmaMF.DataAccess;
using FirmaMF.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace FirmaMF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly IRepository<Job> jobRepository;

        public JobsController(IRepository<Job> jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Job> GetAllJobs() => this.jobRepository.GetAll();
    }
}
