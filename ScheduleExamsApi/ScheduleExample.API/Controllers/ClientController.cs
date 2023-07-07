using Microsoft.AspNetCore.Mvc;
using ScheduleExams.Application.Interface;

namespace ScheduleExams.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientBusiness _clientBusiness;
        public ClientController(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync()
        {
            var result = await _clientBusiness.AddAsync(null);
            return Ok(result);
        }
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync()
        {
            var result = await _clientBusiness.UpdateAsync(null);
            return Ok(result);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteAsync()
        {
            var result = await _clientBusiness.DeleteAsync(default);
            return Ok(result);
        }
        [HttpGet("{cpf}")]
        public async Task<IActionResult> GetByCpfAsync(string cpf)
        {
            var result = await _clientBusiness.GetByCpfAsync(default);
            return Ok(result);
        }
    }
}
