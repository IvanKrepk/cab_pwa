// Controllers/CabPwaController.cs
using CabPwaApi.Models.Office;
using CabPwaApi.Models.Office.Tables;
using CabPwaApi.Requests;
using CabPwaApi.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CabPwaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabPwaController : ControllerBase
    {
        // Инструмент для логирования
        private readonly ILogger<CabPwaController> _logger;

        private readonly IConfiguration _configuration;

        // Контекст базы данных
        private readonly OfficeDBContext _context;

        public CabPwaController(OfficeDBContext context, ILogger<CabPwaController> logger, IConfiguration configuration)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
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
        ///         -H 'X-Client-ID: 9485b3a0-f0a8-4ecd-9dbe-dd5d827c95ab'
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
        [ProducesResponseType(typeof(Response), 200)]
        [ProducesResponseType(typeof(Response), 401)]
        public async Task<ActionResult<Response>> Login([FromBody] RequestLogin loginRequest)
        {
            // Id клиента
            string clientId = Request.Headers["X-Client-ID"].ToString();

            // Генерируем токен авторизации
            var jwtKey = _configuration["Jwt:Key"];
            var jwtIssuer = _configuration["Jwt:Issuer"];
            var jwtAudience = _configuration["Jwt:Audience"];

            if (string.IsNullOrEmpty(jwtKey) || string.IsNullOrEmpty(jwtIssuer))
            {
                return StatusCode(500, "JWT configuration is missing");
            }

            var claims = new[]
            {
                new Claim("userId", clientId),
                new Claim(ClaimTypes.Name, "username"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: jwtAudience,
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);


            _logger.Log(LogLevel.Information, "({0}) Попытка залогиниться, login - {1}", clientId, loginRequest.web_login);

            var accounts = await (
                from W in _context.VWebLoginsAndAllAccounts
                join A in _context.Accounts on W.AccountNumber equals A.AccountNumber
                join WA in _context.WebAccessLogins on W.WebLogin equals WA.WebLogin
                where WA.WebLogin == loginRequest.web_login
                select new { WA.WebLogin, WA.PassHash, WA.AllAccounts, Account = A }).ToListAsync();

            if (accounts.Count <= 0)
            {
                _logger.Log(LogLevel.Information,
                    "({0}) Не удалось войти в Кабинет водителя (Неправильный логин или аккаунт не существует).", clientId);

                return StatusCode(401, new ResponseError
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
                _logger.Log(LogLevel.Information, "({0}) Неправильный пароль. Проверьте раскладку клавиатуры.", clientId);

                return StatusCode(401, new ResponseError
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
                    _logger.Log(LogLevel.Information, "({0}) Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица",
                        clientId);

                    return StatusCode(401, new ResponseError
                    {
                        message = "Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица"
                    });
                }
                else
                {
                    string webLogin = vCardAccounts.First().WebLogin;
                    string? accountName = vCardAccounts.First().Account.AccountName;
                    int? cardCode = vCardAccounts.First().Account.CardEmitentCode;
                    int? cardNumber = vCardAccounts.First().Account.CardGraphNumber;
                    string cardFullNumber = (vCardAccounts.First().Account.CardGraphNumber != null) ?
                        $"{vCardAccounts.First().Account.CardEmitentCode}-{vCardAccounts.First().Account.CardGraphNumber}" :
                        $"{vCardAccounts.First().Account.CardEmitentCode}";
                    int? emitendCode = vCardAccounts.First().Account.CardEmitentCode;
                    int? accountNumber = vCardAccounts.First().Account.AccountNumber;

                    _logger.Log(LogLevel.Information, $"({clientId}) Успешный вход в систему!{Environment.NewLine}" +
                        $"  web_login: {webLogin}{Environment.NewLine}" +
                        $"  account_name: {accountName}{Environment.NewLine}" +
                        $"  card_code: {cardCode}{Environment.NewLine}" +
                        $"  card_number: {cardNumber}{Environment.NewLine}" +
                        $"  card_full_number: {cardFullNumber}{Environment.NewLine}" +
                        $"  emitend_code: {emitendCode}{Environment.NewLine}" +
                        $"  account_number: {accountNumber}");

                    return StatusCode(200, new ResponseLoginSuccess
                    {
                        web_login = vCardAccounts.First().WebLogin,
                        account_name = vCardAccounts.First().Account.AccountName,
                        card_code = vCardAccounts.First().Account.CardEmitentCode,
                        card_number = vCardAccounts.First().Account.CardGraphNumber,
                        card_full_number = (vCardAccounts.First().Account.CardGraphNumber != null) ?
                            $"{vCardAccounts.First().Account.CardEmitentCode}-{vCardAccounts.First().Account.CardGraphNumber}" :
                            $"{vCardAccounts.First().Account.CardEmitentCode}",
                        emitend_code = vCardAccounts.First().Account.CardEmitentCode,
                        account_number = vCardAccounts.First().Account.AccountNumber,
                        token = tokenString
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
                    _logger.Log(LogLevel.Information, 
                        "({0}) Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица (Аккаунт должен иметь привязанную виртуальную карту).",
                        clientId);

                    return StatusCode(401, new ResponseError
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
                        _logger.Log(LogLevel.Information, 
                            "({0}) Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица (Аккаунт должен иметь доступ только к привязанной виртуальной карте.", 
                            clientId);

                        return StatusCode(401, new ResponseError
                        {
                            message = "Не удалось войти в Кабинет водителя. Войдите в кабинет юр. лица (Аккаунт должен иметь доступ только к привязанной виртуальной карте."
                        });
                    }
                    else
                    {
                        _logger.Log(LogLevel.Information, 
                            "({0}) Не удалось войти в Кабинет водителя (Аккаунт не существует).",
                            clientId);

                        return StatusCode(401, new ResponseError
                        {
                            message = "Не удалось войти в Кабинет водителя (Аккаунт не существует)."
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Редактировать данные аккаунта.
        /// </summary>
        /// <remarks>
        /// 
        /// Требует <b><font color="blue">номер аккаунта</font></b>, <b><font color="blue">новое имя аккаунта</font></b><br/> и/или <b><font color="blue">новый пароль</font></b><br/>
        /// Токен передается через заголовок <b><font color="blue">X-API-Token</font></b> или через параметр <b><font color="blue">api_token</font></b> в теле запроса
        ///       
        /// <b>Пример запроса:</b>
        /// 
        ///     curl -X 'POST' \
        ///         'https://localhost:7247/CabPwa/account/update' \
        ///         -H 'accept: application/json' \
        ///         -H 'Content-Type: application/json' \
        ///         -H 'X-Client-ID: 9485b3a0-f0a8-4ecd-9dbe-dd5d827c95ab'
        ///         -d '{
        ///                 "account_number": 43533,
        ///                 "account_name_new": "New Name"
        ///                 "password_new": "32wdad412"
        ///         }'
        ///       
        /// <b>Пример ответа:</b>
        /// 
        ///     {
        ///         "message": "Данные аккаунта успешно отредактированы",
        ///     }
        /// 
        /// </remarks>
        /// <response code="200">Данные об аккаунте успешно отредактированы</response>
        /// <response code="401">Ошибка редактирования</response>
        [HttpPost("account/update")]
        [Produces("application/json")]
        [Authorize]                                                  // эта атрибут говорит: "требуется валидный токен"
        [ProducesResponseType(typeof(Response), 200)]
        [ProducesResponseType(typeof(Response), 400)]
        [ProducesResponseType(typeof(Response), 401)]
        public async Task<ActionResult<Response>> AccountUpdate([FromBody] RequestAccountUpdate request)
        {
            // Id клиента
            string clientId = Request.Headers["X-Client-ID"].ToString();

            bool isAccountNameEmpty = request.account_name_new == string.Empty;
            bool isAccountNameChanged = false;
            bool isPasswordChanged = request.password_new != string.Empty;

            _logger.Log(LogLevel.Information, $"({clientId}) Обновление аккаунта {Environment.NewLine}" +
                $"  Номер аккаунта - {request.account_number}{Environment.NewLine}" +
                $"  Новое имя - {request.account_name_new}{Environment.NewLine}" +
                $"{(isPasswordChanged ? "  Пароль не изменился" : "  Задан новый пароль")}");

            if (isAccountNameEmpty)
            {
                return StatusCode(400, new ResponseError()
                {
                    message = "Задано пустое имя аккаунта"
                });
            }
            
            var account = await _context.Accounts.Where(a => a.AccountNumber == request.account_number).FirstOrDefaultAsync();
            if (account != null)
            {
                // Заменяем на новое имя аккаунта
                if (!account.AccountName!.Equals(request.account_name_new))
                {
                    account.AccountName = request.account_name_new;
                    isAccountNameChanged = true;
                }

                // Проверяем изменился ли пароль
                if (isPasswordChanged)
                {
                    // Ищем логин, пароль которого требуется сменить
                    var webLogin = await (
                        from webLoginsAndAccounts in _context.VWebLoginsAndAccounts
                        join webAccessLogins in _context.WebAccessLogins
                           on webLoginsAndAccounts.Id equals webAccessLogins.Id
                        join accounts in _context.Accounts
                            on webLoginsAndAccounts.AccountNumber equals accounts.AccountNumber
                        where (webAccessLogins.WebLogin == request.web_login) &&
                            (accounts.AccountNumber == request.account_number)
                        select new
                        {
                            webAccessLogins.Id,
                            webAccessLogins.WebLogin,
                            accounts.AccountNumber
                        }).FirstOrDefaultAsync();
 
                    // Если нашли подходящий логин, меняем пароль
                    if (webLogin != null)
                    {
                        var webAccessLogin = await _context.WebAccessLogins.Where(
                            WAL => WAL.Id == webLogin.Id
                        ).FirstOrDefaultAsync();

                        if (webAccessLogin != null)
                        {
                            webAccessLogin.PassHash = Utils.ComputeMD5(request.password_new);
                        }
                    }
                }
            }
            

            string messageResponse = string.Empty;
            if (isAccountNameChanged && isPasswordChanged)
            {
                messageResponse = "Имя аккаунта и пароль успшно изменены!";
            } 
            else if (isAccountNameChanged && (!isPasswordChanged))
            {
                messageResponse = "Имя аккаунта успешно изменено!";
            }
            else if ((!isAccountNameChanged) && isPasswordChanged)
            {
                messageResponse = "Пароль успешно изменён!";
            }

            await _context.SaveChangesAsync();
            return new ResponseAccountUpdate
            {
                message = messageResponse,
                account_name_new = isAccountNameChanged ? request.account_name_new : null,
            };
        }
    }
}
