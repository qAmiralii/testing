using System;
using Tourino.Core.Actors;
using Tourino.Core.Enums;

namespace Tourino.Core.Entities;

public class TourLeaderProfile : TourLeader
{
    public Guid TourLeaderId { get; set; } // وقتی ارث بری میکنه لازمه بازم بگمش؟
    public required  TourLeader TourLeader { get; set; }
    public string? Bio { get; set; }
    public ExperienceLevel ExperienceLevel { get; set; } = ExperienceLevel.Beginner;
    public List<string> Licenses { get; set; } // مجوزها و مدارک تورلیدری
    public Dictionary<string, string> SocialMediaLinks { get; set; } //Gpt but have issuse
    public bool ShowPhoneNumber { get; set; } = false;
    public bool ShowFullName { get; set; } = true;
    public bool ShowExperience { get; set; } = true;
    public bool IsVerified { get; set; } = false;
    public double Rating { get; set; } = 0;
    public required string ReferralLink { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
