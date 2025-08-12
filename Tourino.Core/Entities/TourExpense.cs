using System;
using Tourino.Common.Core.Entities;

namespace Tourino.Core.Things;

public class TourExpense : SQLThing
{
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }
    public string Title { get; set; }         
    public string? Description { get; set; }      
    public decimal Amount { get; set; }           
    public string? PaidBy { get; set; }          
    public DateTime ExpenseDate { get; set; }     
}
