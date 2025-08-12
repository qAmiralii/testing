using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourPassenger : SQLThing
{
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }
    public Guid UserId { get; set; }
    public string FullName { get; set; }
    public int PhoneNumber { get; set; }
    public Gender Gender { get; set; }
    public int MaxAge { get; set; }
    public bool HasPaid { get; set; } = false;
    public bool IsPresent { get; set; } = false;
    public PassengerStatus Status { get; set; }
    public string? TicketCode { get; set; }
}


