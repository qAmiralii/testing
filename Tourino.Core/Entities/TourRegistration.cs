using System;
using Tourino.Core.Actors;
using Tourino.Core.Enums;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourRegistration
{
    public int TravelerId { get; set; }
    public required Traveler Traveler { get; set; }
    public int TourId { get; set; }
    public required Tour Tour { get; set; }
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    public int? NumberOfSeats { get; set; }    // شماره صندلی ها
    public DocumentStatus IsPaidStatus { get; set; } = DocumentStatus.Pending;
    public required string PaymentReference { get; set; }    // شماره تراکنش 

}
