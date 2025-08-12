using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourPhoto : SQLThing
{
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }
    public string Url { get; set; }
    public DateTime UploadTime { get; set; }
    public string? UploadBy { get; set; }
}
