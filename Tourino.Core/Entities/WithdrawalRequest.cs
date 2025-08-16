using System;
using Tourino.Core.Enums;

namespace Tourino.Core.Entities;

public class WithdrawalRequest
{
    public Guid WalletId { get; set; }
    public required TourLeaderWallet Wallet { get; set; } 
    public double Amount { get; set; }
    public DateTime RequestDate { get; set; }
    public WithdrawalStatus Status { get; set; } = WithdrawalStatus.Pending;
    public Guid BankCardId { get; set; }
    public BankCard BankCard { get; set; } = null!;
}
