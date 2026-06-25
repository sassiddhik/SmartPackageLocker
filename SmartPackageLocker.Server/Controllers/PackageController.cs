using Microsoft.AspNetCore.Mvc;

[ApiController] 
public class PackageController : ControllerBase {

    private readonly AppDbContext _db;

    public PackageController(AppDbContext db)
    {
        _db = db;
    }


    [HttpPost("assign")]
    public IActionResult Assign(PackageItem package)
    {
        package.PickupCode =
            Random.Shared.Next(100000, 999999)
            .ToString();

        package.Status = "Stored";

        _db.Packages.Add(package);

        var locker =
            _db.Lockers.Find(package.LockerId);

        locker.Status = "Occupied";

        _db.SaveChanges();

        return Ok(package);
    }

    [HttpPost("pickup")]
    public IActionResult Pickup(string pickupCode)
    {
        var package =
            _db.Packages.FirstOrDefault(x =>
                x.PickupCode == pickupCode);

        if (package == null)
            return BadRequest();

        package.Status = "Collected";

        var locker =
            _db.Lockers.Find(package.LockerId);

        locker.Status = "Available";

        _db.SaveChanges();

        return Ok();
    }

}