using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;

namespace Tourino.Core.Things;

public class Tour : SQLThing
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Capacity { get; set; }
    public int BookedCount { get; set; }
    public decimal PricePerPerson { get; set; }
    public required string Location { get; set; }
    public TourStatus Status { get; set; }
    public List<string>? Tags { get; set; }
    public List<string>? GalleryUrls { get; set; }
    public bool IsVIP { get; set; }
    public required string MeetingPoint { get; set; }
    public required List<string> TourServices { get; set; } ///??????????????
    public required string CancellationPolicy { get; set; }
    public int? MinAge { get; set; } //!!!!!!
    public int? MaxAge { get; set; } //!!!!!!
    public GenderRule GenderRestriction { get; set; }
}
