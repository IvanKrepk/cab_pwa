// Controllers/CabPwaController.cs
using CabPwaApi.Models.Office;
using CabPwaApi.Requests;
using CabPwaApi.Responses.LoginResponse;
using Microsoft.AspNetCore.Mvc;

namespace CabPwaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabPwaController : ControllerBase
    {
        // Инструмент для логирования
        private readonly ILogger<CabPwaController> _logger;

        // Контекст базы данных
        private readonly OfficeDBContext _context;

        public CabPwaController(OfficeDBContext context, ILogger<CabPwaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Попытка залогиниться в системе.
        /// </summary>
        /// <remarks>
        /// 
        /// Требует <b><font color="blue">логин</font></b> и <b><font color="blue">пароль</font></b><br/>
        /// Токен передается через заголовок <b><font color="blue">X-API-Token</font></b> или через параметр <b><font color="blue">api_token</font></b> в теле запроса
        ///       
        /// <b>Пример запроса:</b>
        /// 
        ///     curl -X 'POST' \
        ///         'https://localhost:7247/CabPwa/login' \
        ///         -H 'accept: application/json' \
        ///         -H 'Content-Type: application/json' \
        ///         -d '{
        ///                 "web_login": "333",
        ///                 "password": "333"
        ///         }'
        ///       
        /// <b>Пример ответа:</b>
        /// 
        ///     {
        ///         "user_name": "333",
        ///         "display_name": "4185",
        ///         "card_code": 3881,
        ///         "card_number": null,
        ///         "card_full_number": "3881",
        ///         "emitent_code": 3881,
        ///         "account_number": 4185,
        ///         "token": "ASqVvYZSPDZvVhqIZiBuLSmxN9hVQ4UQZhYnBd58gGs="
        ///     }
        /// 
        /// </remarks>
        /// <response code="200">Возвращает информацию о логине</response>
        /// <response code="401">Ошибка авторизации</response>
        [HttpPost("login")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(LoginResponse), 200)]
        [ProducesResponseType(typeof(LoginResponse), 401)]
        public ActionResult<LoginResponse> Login([FromBody] LoginRequest loginRequest)
        {
            _logger.Log(LogLevel.Information, "Попытка залогиниться, login - {0}", loginRequest.web_login);

            var accounts = (
                from W in _context.VWebLoginsAndAllAccounts
                join A in _context.Accounts on W.AccountNumber equals A.AccountNumber
                join WA in _context.WebAccessLogins on W.WebLogin equals WA.WebLogin
                where WA.WebLogin == loginRequest.web_login
                select new { WA.WebLogin, WA.PassHash, WA.AllAccounts, Account = A }).ToList();

            if (accounts.Count <= 0)
            {
                return StatusCode(401, new LoginResponseError
                {
                    message = "Не удалось войти в Кабинет водителя (Неправильный логин или аккаунт не существует)."
                });
            }

            var isPasswordAccepted = (
                from A in accounts
                where A.PassHash.ToLower().Equals(Utils.ComputeMD5(loginRequest.password).ToLower())
                select A).Count() > 0;

            if (!isPasswordAccepted)
            {
                return StatusCode(401, new LoginResponseError
                {
                    message = "Неправильный пароль. Проверьте раскладку клавиатуры."
                });
            }

            var vCardAccounts = (
                from A in accounts
                where A.AllAccounts == 0 && A.Account.CardIsVirtual == 1
                select A).ToList();

            if (vCardAccounts.Count > 0)
            {
                if (vCardAccounts.Count > 1)
                {
                    return StatusCode(401, new LoginResponseError
                    {
                        message = "Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица"
                    });
                }
                else
                {
                    return StatusCode(200, new LoginResponseSuccess
                    {
                        user_name = vCardAccounts.First().WebLogin,
                        display_name = vCardAccounts.First().Account.AccountName,
                        card_code = vCardAccounts.First().Account.CardEmitentCode,
                        card_number = vCardAccounts.First().Account.CardGraphNumber,
                        card_full_number = (vCardAccounts.First().Account.CardGraphNumber != null) ? 
                            $"{vCardAccounts.First().Account.CardEmitentCode}-{vCardAccounts.First().Account.CardGraphNumber}" :
                            $"{vCardAccounts.First().Account.CardEmitentCode}",
                        emitend_code = vCardAccounts.First().Account.CardEmitentCode,
                        account_number = vCardAccounts.First().Account.AccountNumber,
                        token = Utils.GenerateToken(loginRequest.web_login,
                            loginRequest.password, 
                            vCardAccounts.First().Account.AccountNumber)
                    });   
                }
            }
            else
            {
                vCardAccounts = (
                        from A in accounts
                        where A.AllAccounts == 0 && A.Account.CardIsVirtual == 0
                        select A).ToList();
                if (vCardAccounts.Count > 0)
                {
                    return StatusCode(401, new LoginResponseError
                    {
                        message = "Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица (Аккаунт должен иметь привязанную виртуальную карту)."
                    });
                }
                else
                {
                    vCardAccounts = (
                        from A in accounts
                        where A.AllAccounts == 1 && A.Account.CardIsVirtual == 1
                        select A).ToList();
                    if (vCardAccounts.Count > 0)
                    {
                        return StatusCode(401, new LoginResponseError
                        {
                            message = "Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица (Аккаунт должен иметь доступ только к привязанной виртуальной карте."
                        });
                    }
                    else
                    {
                        return StatusCode(401, new LoginResponseError
                        {
                            message = "Не удалось войти в Кабинет водителя (Аккаунт не существует)."
                        });
                    }
                }
            }
        }
    }
}
