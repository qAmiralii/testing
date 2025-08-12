using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourPlan : SQLThing
{
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }
    public int DayNumber { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string? LocationName { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public List<TourTasks> Tasks { get; set; } = new(); //???
}
