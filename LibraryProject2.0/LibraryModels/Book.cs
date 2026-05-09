using System;
using System.Collections.Generic;

namespace LibraryProject2._0.LibraryModels;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public short? PublishedYear { get; set; }

    public string? Publisher { get; set; }

    public virtual ICollection<BookItem> BookItems { get; set; } = new List<BookItem>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();
}
