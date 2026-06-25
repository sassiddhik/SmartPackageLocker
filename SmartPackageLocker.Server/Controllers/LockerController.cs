using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[ApiController]
[Route("api/locker")]
public class LockerController : ControllerBase
{
    private readonly AppDbContext _db;

    public LockerController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_db.Lockers.ToList());
    }

    [HttpPost]
    public IActionResult Create(Locker locker)
    {
        _db.Lockers.Add(locker);
        _db.SaveChanges();

        return Ok(locker);
    }
}