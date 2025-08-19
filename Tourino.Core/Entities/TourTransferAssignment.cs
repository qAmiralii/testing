using System;
using System.ComponentModel.DataAnnotations;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourTransferAssignment : SQLThing
{
    public required Guid TourId { get; set; }
    public required Tour Tour { get; set; }
    public Guid VehicleId { get; set; }
    public required Vehicle Vehicle { get; set; }
    /// <summary>
    /// Gpt
    /// </summary>
    public string? Notes { get; set; }
    public DateTime DepartureAt { get; set; }              // زمان حرکت
    public DateTime? ReturnAt { get; set; }
    ///
    public TransferStatus Status { get; set; } = TransferStatus.Scheduled;

}
