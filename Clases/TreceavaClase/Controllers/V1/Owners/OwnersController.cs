using Microsoft.AspNetCore.Mvc;
using TreceavaClase.Models;

namespace TreceavaClase.Controllers.V1.Owners;

[ApiController]
[Route("api/[controller]")]
public class OwnersController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("hola mundo, este es mi primer endpoint");
    }
    
}
