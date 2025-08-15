using Microsoft.AspNetCore.Mvc;
using Moq;
using TheHMS.ApiService.Controller.Auth;
using TheHMS.IService.IService.Auth;

namespace TheHMS.Tests.Controller
{
    public class AuthControllerTests
    {
        private readonly Mock<IAuth> _authServiceMock;
        private readonly ApiService.Controller.Auth.AuthControllerTests _controller;

        public AuthControllerTests()
        {
            _authServiceMock = new Mock<IAuth>();
            _controller = new ApiService.Controller.Auth.AuthControllerTests(_authServiceMock.Object);
        }

        [Fact]
        public async Task Login_ShouldReturnBadRequest_WhenLoginDataIsNull()
        {
            // Act
            var result = await _controller.Login(null);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Username and password are required.", badRequest.Value);
        }

        [Fact]
        public async Task Login_ShouldReturnBadRequest_WhenUsernameOrPasswordIsEmpty()
        {
            // Arrange
            dynamic loginData = new { username = "", password = "" };

            // Act
            var result = await _controller.Login(loginData);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Username and password are required.", badRequest.Value);
        }

        

         
    }

}
