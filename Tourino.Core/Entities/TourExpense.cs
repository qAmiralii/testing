using System;
using Tourino.Common.Core.Entities;

namespace Tourino.Core.Things;

public class TourExpense : SQLThing
{
    // هزینه تور
    public Guid TourId { get; set; }
    public required Tour Tour { get; set; }
    public required string Title { get; set; }         
    public string? Description { get; set; }      
    public decimal Amount { get; set; }           
    public required string PaidBy { get; set; }          
    public DateTime ExpenseDate { get; set; }     
}
