using System;
using System.Collections.Generic;

namespace FUMiniHotelManagement.DAL.Models;

public partial class BookingDetail
{
    public int BookingReservationId { get; set; }

    public int RoomId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public decimal? ActualPrice { get; set; }

    public virtual decimal? SubTotal
    {
        get
        {
            var days = EndDate.DayNumber - StartDate.DayNumber + 1;

            return days * ActualPrice;

        }
    }

    public virtual BookingReservation BookingReservation { get; set; } = null!;

    public virtual RoomInformation Room { get; set; } = null!;
}
