using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Enums;

namespace Tourino.Core.Actors;

public class User : SQLThing
{
    public string? ProfilePhotoUrl { get; set; }
    public required string Username { get; set; }
    public required string PasswordHash { get; set; }
    public string? Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public Gender Gender { get; set; }
    public required DateTime BirthDate { get; set; }
}
