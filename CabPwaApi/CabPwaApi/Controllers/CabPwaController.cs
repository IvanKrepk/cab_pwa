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
        // ���������� ��� �����������
        private readonly ILogger<CabPwaController> _logger;

        // �������� ���� ������
        private readonly OfficeDBContext _context;

        public CabPwaController(OfficeDBContext context, ILogger<CabPwaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        private bool _checkClientToken(string token, string clientId)
        {
            // !!! �������� �����!!!
            // ...
            _logger.Log(LogLevel.Information, $"({clientId}) �������� ������ ������ �������");
            return true;
        }

        /// <summary>
        /// ������� ������������ � �������.
        /// </summary>
        /// <remarks>
        /// 
        /// ������� <b><font color="blue">�����</font></b> � <b><font color="blue">������</font></b><br/>
        /// ����� ���������� ����� ��������� <b><font color="blue">X-API-Token</font></b> ��� ����� �������� <b><font color="blue">api_token</font></b> � ���� �������
        ///       
        /// <b>������ �������:</b>
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
        /// <b>������ ������:</b>
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
        /// <response code="200">���������� ���������� � ������</response>
        /// <response code="401">������ �����������</response>
        [HttpPost("login")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Response), 200)]
        [ProducesResponseType(typeof(Response), 401)]
        public ActionResult<Response> Login([FromBody] RequestLogin loginRequest)
        {
            // Id �������
            string clientId = Request.Headers["X-Client-ID"].ToString();

            _logger.Log(LogLevel.Information, "({0}) ������� ������������, login - {1}", clientId, loginRequest.web_login);

            var accounts = (
                from W in _context.VWebLoginsAndAllAccounts
                join A in _context.Accounts on W.AccountNumber equals A.AccountNumber
                join WA in _context.WebAccessLogins on W.WebLogin equals WA.WebLogin
                where WA.WebLogin == loginRequest.web_login
                select new { WA.WebLogin, WA.PassHash, WA.AllAccounts, Account = A }).ToList();

            if (accounts.Count <= 0)
            {
                _logger.Log(LogLevel.Information,
                    "({0}) �� ������� ����� � ������� �������� (������������ ����� ��� ������� �� ����������).", clientId);

                return StatusCode(401, new ResponseError
                {
                    message = "�� ������� ����� � ������� �������� (������������ ����� ��� ������� �� ����������)."
                });
            }

            var isPasswordAccepted = (
                from A in accounts
                where A.PassHash.ToLower().Equals(Utils.ComputeMD5(loginRequest.password).ToLower())
                select A).Count() > 0;

            if (!isPasswordAccepted)
            {
                _logger.Log(LogLevel.Information, "({0}) ������������ ������. ��������� ��������� ����������.", clientId);

                return StatusCode(401, new ResponseError
                {
                    message = "������������ ������. ��������� ��������� ����������."
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
                    _logger.Log(LogLevel.Information, "({0}) �� ������� ����� � ������� ��������. ������� � ������� ��. ����",
                        clientId);

                    return StatusCode(401, new ResponseError
                    {
                        message = "�� ������� ����� � ������� ��������. ������� � ������� ��. ����"
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

                    _logger.Log(LogLevel.Information, $"({clientId}) �������� ���� � �������!{Environment.NewLine}" +
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
                        "({0}) �� ������� ����� � ������� ��������. ������� � ������� ��. ���� (������� ������ ����� ����������� ����������� �����).",
                        clientId);

                    return StatusCode(401, new ResponseError
                    {
                        message = "�� ������� ����� � ������� ��������. ������� � ������� ��. ���� (������� ������ ����� ����������� ����������� �����)."
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
                            "({0}) �� ������� ����� � ������� ��������. ������� � ������� ��. ���� (������� ������ ����� ������ ������ � ����������� ����������� �����.", 
                            clientId);

                        return StatusCode(401, new ResponseError
                        {
                            message = "�� ������� ����� � ������� ��������. ������� � ������� ��. ���� (������� ������ ����� ������ ������ � ����������� ����������� �����."
                        });
                    }
                    else
                    {
                        _logger.Log(LogLevel.Information, 
                            "({0}) �� ������� ����� � ������� �������� (������� �� ����������).",
                            clientId);

                        return StatusCode(401, new ResponseError
                        {
                            message = "�� ������� ����� � ������� �������� (������� �� ����������)."
                        });
                    }
                }
            }
        }

        /// <summary>
        /// ������������� ������ ��������.
        /// </summary>
        /// <remarks>
        /// 
        /// ������� <b><font color="blue">����� ��������</font></b>, <b><font color="blue">����� ��� ��������</font></b><br/> �/��� <b><font color="blue">����� ������</font></b><br/>
        /// ����� ���������� ����� ��������� <b><font color="blue">X-API-Token</font></b> ��� ����� �������� <b><font color="blue">api_token</font></b> � ���� �������
        ///       
        /// <b>������ �������:</b>
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
        /// <b>������ ������:</b>
        /// 
        ///     {
        ///         "message": "������ �������� ������� ���������������",
        ///     }
        /// 
        /// </remarks>
        /// <response code="200">������ �� �������� ������� ���������������</response>
        /// <response code="401">������ ��������������</response>
        [HttpPost("account/update")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Response), 200)]
        [ProducesResponseType(typeof(Response), 401)]
        public ActionResult<Response> AccountUpdate([FromBody] RequestAccountUpdate request)
        {
            // Id �������
            string clientId = Request.Headers["X-Client-ID"].ToString();

            string token = Request.Headers["X-Client-Token"].ToString();
            if (_checkClientToken(token, clientId))
            {
                _logger.Log(LogLevel.Information, $"({clientId}) ���������� �������� {Environment.NewLine}" +
                    $"  ����� �������� - {request.account_number}{Environment.NewLine}" +
                    $"  ����� ��� - {request.account_name_new}{Environment.NewLine}" +
                    $"{(request.password_new == string.Empty ? "  ������ �� ���������" : "  ����� ����� ������")}");

                return new ResponseAccountUpdate
                {
                    message = "OK"
                };
            } else
            {
                _logger.Log(LogLevel.Information, $"({clientId}) �������� ������ �� ������");
                return new ResponseError
                {
                    message = "�������� ������ �� ������"
                };
            }
        }
    }
}
