using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class TakeOutRecord
{
    public int TakeOutId { get; set; }

    public int Barcode { get; set; }

    public int MemberId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public virtual BookItem BarcodeNavigation { get; set; } = null!;

    public virtual ICollection<Fine> Fines { get; set; } = new List<Fine>();

    public virtual Member Member { get; set; } = null!;
}
