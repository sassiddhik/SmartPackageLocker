using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly JwtService _jwt;

    public AuthController(
        AppDbContext db, JwtService jwt)
    {
        _db = db;
        _jwt = jwt;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var user = new User
        {
            Email = request.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
        };

        _db.Users.Add(user);
        _db.SaveChanges();

        return Ok();
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var user = _db.Users
            .FirstOrDefault(x =>
                x.Email == request.Email);

        if (user == null)
            return Unauthorized();

        //if (!BCrypt.Net.BCrypt.Verify(
        //    request.Password,
        //    user.PasswordHash))
        //    return Unauthorized();

        var token =  _jwt.GenerateToken(user);

        return Ok(token);
    }
}