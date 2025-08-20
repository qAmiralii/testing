using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class Notification : SQLThing
{
    public Guid TourId { get; set; }
    public required Tour Tour { get; set; }
    public required string Title { get; set; }
    public required string Message { get; set; }
    public DateTime SentTime { get; set; }
    public NotificationType Type { get; set; } 
    public required List<NotificationRecipient> Recipients { get; set; } // چه کسانی

}
