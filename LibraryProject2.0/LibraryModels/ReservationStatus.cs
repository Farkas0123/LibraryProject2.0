using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class ReservationStatus
{
    public string StatusCode { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
