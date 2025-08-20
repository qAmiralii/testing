using System;
using Tourino.Common.Core.Entities;

namespace Tourino.Core.Things
{
    public class TourEmergencyContact : SQLThing
    {
        public Guid TourId { get; set; }
        public required Tour Tour { get; set; }
        public required string Title { get; set; }
        public required List<string> PhoneNumber { get; set; }
        public string? Description { get; set; }
    }
}
