using BCrypt.Net;

public static class SeedData
{
    public static void Initialize(AppDbContext db)
    {
        if (db.Users.Any())
            return;

        db.Users.AddRange(
            new User
            {
                Id = 1,
                Email = "smartadmin@locker.com",
                PasswordHash =
                    BCrypt.Net.BCrypt.HashPassword("Admin1234"),
                Role = "Admin"
            },
            new User
            {
                Id = 2,
                Email = "smartuser@locker.com",
                PasswordHash =
                    BCrypt.Net.BCrypt.HashPassword("User1234"),
                Role = "User"
            }
        );

        db.Lockers.AddRange(
            new Locker
            {
                Id = 1,
                LockerNumber = "LN101",
                Size = "Small",
                Status = "Available"
            },
            new Locker
            {
                Id = 2,
                LockerNumber = "LN102",
                Size = "Medium",
                Status = "Occupied"
            },
            new Locker
            {
                Id = 3,
                LockerNumber = "LN103",
                Size = "Large",
                Status = "Available"
            },
            new Locker
            {
                Id = 4,
                LockerNumber = "LN201",
                Size = "Medium",
                Status = "Occupied"
            }
        );

        db.Packages.AddRange(
            new PackageItem
            {
                Id = 1,
                TrackingNumber = "TN10001",
                RecipientName = "Barry Smith",
                LockerId = 2,
                PickupCode = "123456",
                Status = "Stored"
            },
            new PackageItem
            {
                Id = 2,
                TrackingNumber = "TN10002",
                RecipientName = "Victoria Secret",
                LockerId = 4,
                PickupCode = "654321",
                Status = "Stored"
            }
        );

        db.SaveChanges();
    }
}