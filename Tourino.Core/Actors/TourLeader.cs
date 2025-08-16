using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;

namespace Tourino.Core.Actors;

public class TourLeader : User
{
    // Gpt
    public bool IsActive { get; set; } = true;
    public bool IsBlocked { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastLoginAt { get; set; }
    public string? ReferralCode { get; set; }

}
