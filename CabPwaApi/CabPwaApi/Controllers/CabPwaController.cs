// Controllers/CabPwaController.cs
using CabPwaApi.Models.Office;
using CabPwaApi.Requests;
using CabPwaApi.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

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

        private bool _checkClientToken(string token, string clientId)
        {
            // !!! Доделать позже!!!
            // ...
            _logger.Log(LogLevel.Information, $"({clientId}) Проверка токена прошла успешно");
            return true;
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
        public ActionResult<Response> Login([FromBody] RequestLogin loginRequest)
        {
            // Id клиента
            string clientId = Request.Headers["X-Client-ID"].ToString();

            _logger.Log(LogLevel.Information, "({0}) Попытка залогиниться, login - {1}", clientId, loginRequest.web_login);

            var accounts = (
                from W in _context.VWebLoginsAndAllAccounts
                join A in _context.Accounts on W.AccountNumber equals A.AccountNumber
                join WA in _context.WebAccessLogins on W.WebLogin equals WA.WebLogin
                where WA.WebLogin == loginRequest.web_login
                select new { WA.WebLogin, WA.PassHash, WA.AllAccounts, Account = A }).ToList();

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
                    string userName = vCardAccounts.First().WebLogin;
                    string displayName = vCardAccounts.First().WebLogin;
                    int? cardCode = vCardAccounts.First().Account.CardEmitentCode;
                    int? cardNumber = vCardAccounts.First().Account.CardGraphNumber;
                    string cardFullNumber = (vCardAccounts.First().Account.CardGraphNumber != null) ?
                        $"{vCardAccounts.First().Account.CardEmitentCode}-{vCardAccounts.First().Account.CardGraphNumber}" :
                        $"{vCardAccounts.First().Account.CardEmitentCode}";
                    int? emitendCode = vCardAccounts.First().Account.CardEmitentCode;
                    int? accountNumber = vCardAccounts.First().Account.AccountNumber;
                    string token = Utils.GenerateToken(loginRequest.web_login,
                        loginRequest.password,
                        vCardAccounts.First().Account.AccountNumber);

                    _logger.Log(LogLevel.Information, $"({clientId}) Успешный вход в систему!{Environment.NewLine}" +
                        $"  user_name: {userName}{Environment.NewLine}" +
                        $"  display_name: {displayName}{Environment.NewLine}" +
                        $"  card_code: {cardCode}{Environment.NewLine}" +
                        $"  card_number: {cardNumber}{Environment.NewLine}" +
                        $"  card_full_number: {cardFullNumber}{Environment.NewLine}" +
                        $"  emitend_code: {emitendCode}{Environment.NewLine}" +
                        $"  account_number: {accountNumber}");

                    return StatusCode(200, new ResponseLoginSuccess
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
        [ProducesResponseType(typeof(Response), 200)]
        [ProducesResponseType(typeof(Response), 401)]
        public ActionResult<Response> AccountUpdate([FromBody] RequestAccountUpdate request)
        {
            // Id клиента
            string clientId = Request.Headers["X-Client-ID"].ToString();

            string token = Request.Headers["X-Client-Token"].ToString();
            if (_checkClientToken(token, clientId))
            {
                _logger.Log(LogLevel.Information, $"({clientId}) Обновление аккаунта {Environment.NewLine}" +
                    $"  Номер аккаунта - {request.account_number}{Environment.NewLine}" +
                    $"  Новое имя - {request.account_name_new}{Environment.NewLine}" +
                    $"{(request.password_new == string.Empty ? "  Пароль не изменился" : "  Задан новый пароль")}");

                return new ResponseAccountUpdate
                {
                    message = "OK"
                };
            } else
            {
                _logger.Log(LogLevel.Information, $"({clientId}) Проверка токена не прошла");
                return new ResponseError
                {
                    message = "Проверка токена не прошла"
                };
            }
        }
    }
}
