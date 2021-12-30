using FirmaMF.DataAccess;
using FirmaMF.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace FirmaMF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolController : ControllerBase
    {
        private readonly IRepository<Tool> toolRepository;

        public ToolController(IRepository<Tool> toolRepository)
        {
            this.toolRepository = toolRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Tool> GetAllTools() => this.toolRepository.GetAll();


        [HttpGet]
        [Route("toolId")]
        public Tool GetToolById(int toolId) => this.toolRepository.GetById(toolId);


    }
}
