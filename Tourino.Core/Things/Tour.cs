using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;

namespace Tourino.Core.Things;

public class Tour : SQLThing
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Capacity { get; set; }
    public int BookedCount { get; set; }
    public decimal PricePerPerson { get; set; }
    public string Location { get; set; }
    public TourStatus Status { get; set; }
    public List<string> Tags { get; set; }
    public List<string> GalleryUrls { get; set; }
    public bool IsVIP { get; set; }
    public string MeetingPoint { get; set; }
    public List<string> TourServices { get; set; } ///??????????????
    public string CancellationPolicy { get; set; }
    public int? MinAge { get; set; } //!!!!!!
    public int? MaxAge { get; set; } //!!!!!!
    public GenderRule GenderRestriction { get; set; }
}
