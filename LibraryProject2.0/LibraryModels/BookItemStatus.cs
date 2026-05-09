using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class BookItemStatus
{
    public string StatusCode { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<BookItem> BookItems { get; set; } = new List<BookItem>();
}
