using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace FUMiniHotelManagement.DAL.Models;

public partial class RoomInformation
{
    public int RoomId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string? RoomDetailDescription { get; set; }

    public int? RoomMaxCapacity { get; set; }

    public int RoomTypeId { get; set; }

    public byte? RoomStatus { get; set; }

    public virtual string Status { get => RoomStatus == 1 ? "Active" : "Deleted"; } 

    public decimal? RoomPricePerDay { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

    public virtual RoomType RoomType { get; set; } = null!;

    [NotMapped]
    public virtual bool IsSelected { get; set; } = false;

    [NotMapped]
    public DateTime? StartDate { get; set; }

    [NotMapped]
    public DateTime? EndDate { get; set; }

}
