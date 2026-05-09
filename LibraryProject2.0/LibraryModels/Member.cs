using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class Member
{
    public int MemberId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateOnly JoinDate { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<TakeOutRecord> TakeOutRecords { get; set; } = new List<TakeOutRecord>();
}
