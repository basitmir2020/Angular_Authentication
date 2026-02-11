using AuthService.Application.DTOs;
using AuthService.Domain.Entities;
using AuthService.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwt;

    public AuthController(JwtService jwt)
    {
        _jwt = jwt;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        // Fake user (replace with DB later)
        if (request.Email != "admin@test.com" || request.Password != "123456")
            return Unauthorized();

        var user = new User
        {
            Email = request.Email,
            Role = "Admin"
        };

        var accessToken = _jwt.GenerateToken(user);
        var refreshToken = Guid.NewGuid().ToString();

        return Ok(new AuthResponse(accessToken, refreshToken));
    }
}