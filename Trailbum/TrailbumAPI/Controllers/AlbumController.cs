using Microsoft.AspNetCore.Mvc;

namespace TrailbumAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAlbums()
    {
        await Task.CompletedTask;

        return Ok("All the albums.");
    }
}