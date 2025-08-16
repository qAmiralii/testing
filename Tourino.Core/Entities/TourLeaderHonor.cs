using System;
using Tourino.Common.Core.Entities;

namespace Tourino.Core.Entities;

public class TourLeaderHonor : SQLThing
{
    public Guid TourLeaderProfileId { get; set; }
    public required TourLeaderProfile TourLeaderProfile { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public DateTime? ClaimDate { get; set; }
}
