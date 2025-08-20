using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;
using Tourino.Core.Things;

namespace Tourino.Core.Entities;

public class TourDocument : SQLThing
{
    public Guid TourId { get; set; }
    public required Tour Tour { get; set; }
    public required string Title { get; set; }
    public required string FileUrl { get; set; }  // آدرس فایل 
    public required string FileType { get; set; }
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow; // تاریخ آپلود Gpt
    public bool IsPublick { get; set; } = false;
    public DocumentStatus Status { get; set; } = DocumentStatus.Pending;
    public string? ReviewComment { get; set; } // دلیل رد شدن
}
