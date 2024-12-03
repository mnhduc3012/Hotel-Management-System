using System;
using System.Collections.Generic;

namespace FUMiniHotelManagement.DAL.Models;

public partial class BookingReservation
{
    public int BookingReservationId { get; set; }

    public DateOnly? BookingDate { get; set; }

    public decimal? TotalPrice { get; set; }

    public int CustomerId { get; set; }

    public byte? BookingStatus { get; set; }

    public string? Status
    {
        get
        {
            switch (BookingStatus) 
            {
            
                case 1:
                    return "Pending";
                case 2:
                    return "Completed";
                case 3:
                    return "Canceled";
                default:
                    return null;
            
            }
        }
    }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

    public virtual Customer Customer { get; set; } = null!;
}
