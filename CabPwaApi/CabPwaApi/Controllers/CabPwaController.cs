// Controllers/CabPwaController.cs
using CabPwaApi.Models.Office;
using CabPwaApi.Requests;
using CabPwaApi.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CabPwaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabPwaController : ControllerBase
    {
        // инструмент дл€ логировани€
        private readonly ILogger<CabPwaController> _logger;

        private readonly OfficeDBContext _context;

        public CabPwaController(OfficeDBContext context, ILogger<CabPwaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost("login")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(LoginResponse), 200)]
        public LoginResponse Login([FromBody] LoginRequest loginRequest)
        {
            _logger.Log(LogLevel.Information, "ѕопытка залогинитьс€, login - {0}, password - {1}",
                loginRequest.web_login, loginRequest.password);

            var logins = _context.WebAccessLogins.ToList();

            return new LoginResponse { message = "OK" };
        }
    }
}
