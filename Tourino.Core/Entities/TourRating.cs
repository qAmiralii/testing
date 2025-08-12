using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourRating : SQLThing
{
    public Guid TourGuid { get; set; }
    public required Tour Tour { get; set; }
    public Guid UserId { get; set; }
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
   public bool IsVisible { get; set; } = true;

}
