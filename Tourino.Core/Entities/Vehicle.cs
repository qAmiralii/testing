using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;

namespace Tourino.Core.Entities;

public class Vehicle : SQLThing
{
    public required Guid TourLeaderProfileId { get; set; }
    public required TourLeaderProfile TourLeaderProfile { get; set; }
    public required string LicensePlate { get; set; }
    public required VehicleType VehicleType { get; set; }
    public required int SeatCapacity { get; set; }
    public bool IsActive { get; set; } = true;
    public List<TourTransferAssignment> Assignments { get; set; } = new();
    public required string FullName { get; set; }
    public required string PhoneNumber { get; set; }
    public string? VehiclePhotoUrl { get; set; }
    public string? DriverPhotoUrl { get; set; }
}
