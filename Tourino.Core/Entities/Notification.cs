using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class Notification : SQLThing
{
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
    public DateTime SentTime { get; set; }
    public NotificationType Type { get; set; } 
    public List<NotificationRecipient> Recipients { get; set; } = new();

}
