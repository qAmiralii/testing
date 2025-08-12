using System;

namespace Tourino.Common.Core.Entities;

public class SQLThing
{
    public int Id { get; set; }
    public string Guid { get; set; } = System.Guid.NewGuid().ToString();
}
