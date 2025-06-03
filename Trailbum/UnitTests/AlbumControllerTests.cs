using Microsoft.AspNetCore.Mvc;
using TrailbumAPI.Controllers;

namespace UnitTests;

public class AlbumControllerTests
{
    [Fact]
    public async void Get_ReturnsOk()
    {
        // Arrange
        var controller = new AlbumController();

        // Act
        var response = await controller.GetAlbums();
        
        // Assert
        Assert.IsType<OkObjectResult>(response);
    }
}