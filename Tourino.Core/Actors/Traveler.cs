using System;
using Tourino.Common.Core.Entities;
using Tourino.Core.Entities;

namespace Tourino.Core.Actors;

public class Traveler : User
{
    public required string NationalCode { get; set; }    // کد ملی 
    // ارتباط با تورها
    public ICollection<TourRegistration> TourRegistrations { get; set; }

}
