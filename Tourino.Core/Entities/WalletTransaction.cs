using Tourino.Common.Core.Entities;
using Tourino.Core.Actors;

namespace Tourino.Core.Entities;

public class WalletTransaction : SQLThing
{
    public Guid WalletId { get; set; }
    public TourLeaderWallet Wallet { get; set; } = null!;

    public required Guid BuyerId { get; set; }
    public required User Buyer { get; set; }

    public double Amount { get; set; }
    public TransactionType Type { get; set; }
    public PaymentMode PaymentMode { get; set; }
    public DateTime TransactionDate { get; set; }

    public string? Description { get; set; } // توضیح تراکنش
}
public enum TransactionType
{
    Purchase,     // خرید تور
    Withdrawal,
    Deposit,
    Adjustment    // اصلاح یا تغییرات دستیGpt
}
public enum PaymentMode
{
    Full,
    Installment
}