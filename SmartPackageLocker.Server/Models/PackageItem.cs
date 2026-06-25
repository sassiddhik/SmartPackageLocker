public class PackageItem
{
    public int Id { get; set; }

    public string TrackingNumber { get; set; } = "";

    public string RecipientName { get; set; } = "";

    public int LockerId { get; set; }

    public string PickupCode { get; set; } = "";

    public string Status { get; set; } = "Stored";
}