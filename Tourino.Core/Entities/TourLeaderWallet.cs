using System;
using Tourino.Common.Core.Entities;

namespace Tourino.Core.Entities;

public class TourLeaderWallet : SQLThing
{
    public Guid TourLeaderProfileId { get; set; }
    public required TourLeaderProfile TourLeaderProfile { get; set; }
    public decimal Balance { get; set; } 
    public decimal TotalIncome { get; set; } 
    public decimal PendingIncome { get; set; } 
    public int TransactionCount { get; set; }
    public int WithdrawalCount { get; set; } 

}
