using EMailService.Monolith.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMailService.Monolith.Controllers;

[ApiController]
[Route("api/mail")]
public class MailController : ControllerBase
{
    [HttpPost("get")]
    [ProducesResponseType(typeof(ApiResponse<string>),StatusCodes.Status200OK)]
    public async Task<ApiResponse<string>> Get()
    {
        return new ApiResponse<string>
        {
            StatusCode = 200,
            Message = $"All mails fetched",
            Data = "Success"
        };
    }

    [HttpPost("send")]
    [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status200OK)]
    public async Task<ApiResponse<string>> Send(string email)
    {
        return new ApiResponse<string>
        {
            StatusCode = 200,
            Message = $"Mail sent to {email}",
            Data = "Success"
        };
    }
}
