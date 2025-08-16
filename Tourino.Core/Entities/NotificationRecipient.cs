using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Entities;

namespace Tourino.Core.Things;

public class NotificationRecipient : SQLThing
{
    public Guid NotificationId { get; set; }
    public Notification Notification { get; set; }
    public Guid UserId { get; set; }         
}
