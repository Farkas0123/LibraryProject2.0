using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class BookItem
{
    public int Barcode { get; set; }

    public int BookId { get; set; }

    public string StatusCode { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;

    public virtual BookItemStatus StatusCodeNavigation { get; set; } = null!;

    public virtual ICollection<TakeOutRecord> TakeOutRecords { get; set; } = new List<TakeOutRecord>();
}
