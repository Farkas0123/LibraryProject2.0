using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class Fine
{
    public int FineId { get; set; }

    public int TakeOutId { get; set; }

    public decimal Amount { get; set; }

    public DateOnly IssuedDate { get; set; }

    public DateOnly? PaidDate { get; set; }

    public virtual TakeOutRecord TakeOut { get; set; } = null!;
}
