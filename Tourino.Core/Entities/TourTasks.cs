using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourTasks : SQLThing
{
    public Guid TourPlanId { get; set; }
    public required TourPlan Plan { get; set; }
    public required string Title { get; set; } 
    public string? Description { get; set; }
    public bool IsCompleted { get; set; } = false;
    public string? Icon { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateOnly TaskDate { get; set; }
    public string? ColorCode { get; set; }
}
