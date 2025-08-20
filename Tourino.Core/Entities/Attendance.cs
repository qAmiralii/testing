using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class Attendance : SQLThing
{
    public Guid TourId { get; set; }
    public required Tour Tour { get; set; }
    public DateTime SessionDate { get; set; }
    public ICollection<PassengerAttendance> PassengerAttendances { get; set; }

}
