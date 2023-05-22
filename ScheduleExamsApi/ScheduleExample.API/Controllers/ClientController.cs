using Microsoft.AspNetCore.Mvc;
using ScheduleExams.Application.Interface;

namespace ScheduleExams.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientBusiness _authBusiness;
        public ClientController(IClientBusiness authBusiness)
        {
            _authBusiness = authBusiness;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync()
        {
            return Ok();
        }
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync()
        {
            return Ok();
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteAsync()
        {
            return Ok();
        }
        [HttpGet("{cpf}")]
        public async Task<IActionResult> GetByCpfAsync(string cpf)
        {
            return Ok();
        }
    }
}
