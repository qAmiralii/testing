using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Actors;

namespace Tourino.Core.Entities;

public class TourTransferVehicle : SQLThing
{
    public Guid TourLeaderProfileId { get; set; }  // تورلیدر پروفایل یا فقط تورلیدر؟
    public required TourLeaderProfile TourLeaderProfile { get; set; }
    public required string LicensePlate { get; set; }
    public required string VehicleType { get; set; }
    public required string DriverName { get; set; }
    public required string DriverPhone { get; set; }
    public int Capacity { get; set; }
    public string? DriverPhotoUrl { get; set; }
    public bool IsActive { get; set; } = true;

}
