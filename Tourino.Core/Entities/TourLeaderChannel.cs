using System;
using System.Collections.Generic;
using Tourino.Common.Core.Entities;
using Tourino.Core.Entities;

namespace Tourino.Core.Things
{
    public class TourLeaderChannel : SQLThing
    {
        public Guid TourLeaderProfileId { get; set; }
        public TourLeaderProfile TourLeaderProfile { get; set; } = null!;

        public required string ChannelName { get; set; }
        public required string ChannelId { get; set; }

        public required List<string> RefundPolicy { get; set; } //چون چند قانون متفاوت داریم

        public List<string>? SpecialFeatures { get; set; }

        public string? TourType { get; set; }

        public required string Region { get; set; }

        public string? Description { get; set; }

        // فهرست تورهایی که در این کانال نمایش داده می شوند
        public List<Tour> DisplayedTours { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; //Gpt
    }
}
