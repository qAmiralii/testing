using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Actors;
using Tourino.Core.Enums;

namespace Tourino.Core.Entities;

public class PassengerAttendance : SQLThing
{
    public int AttendanceSessionId { get; set; }
    public required Attendance AttendanceSession { get; set; }
    public int TravelerId { get; set; }
    public required Traveler Traveler { get; set; }
    public AttendanceStatus Status { get; set; }
    // زمان ثبت حضور/غیاب
    public DateTime RecordedAt { get; set; } = DateTime.Now;

}
