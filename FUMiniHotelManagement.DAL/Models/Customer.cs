using System;
using System.Collections.Generic;

namespace FUMiniHotelManagement.DAL.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerFullName { get; set; }

    public string? Telephone { get; set; }

    public string EmailAddress { get; set; } = null!;

    public DateOnly? CustomerBirthday { get; set; }

    public byte? CustomerStatus { get; set; }

    public virtual string Status { get => CustomerStatus == 1 ? "Active" : "Deactivated"; }

    public string? Password { get; set; }

    public virtual ICollection<BookingReservation> BookingReservations { get; set; } = new List<BookingReservation>();

}
