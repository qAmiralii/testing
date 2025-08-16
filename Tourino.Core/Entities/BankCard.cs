using System;
using Tourino.Common.Core.Entities;

namespace Tourino.Core.Entities;

public class BankCard : SQLThing
{
    public Guid TourLeaderProfileId { get; set; }
    public required TourLeaderProfile TourLeaderProfile { get; set; }

    public required string CardNumber { get; set; } 
    public required string BankName { get; set; } 
    public required string AccountHolderName { get; set; }  
    public bool IsPrimary { get; set; }
}
