using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int BookId { get; set; }

    public int MemberId { get; set; }

    public DateTime ReservedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public string StatusCode { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;

    public virtual ReservationStatus StatusCodeNavigation { get; set; } = null!;
}
