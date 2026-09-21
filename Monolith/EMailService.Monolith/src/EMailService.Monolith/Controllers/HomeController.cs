using EMailService.Monolith.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMailService.Monolith.Controllers;

[ApiController]
[Route("api/home")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public async Task<ApiResponse<string>> Index()
    {
        return new ApiResponse<string>
        {
            StatusCode = 200,
            Message = "Success",
            Data = "Success"
        };
    }
}
