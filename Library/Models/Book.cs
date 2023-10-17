using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string PublicationDate { get; set; } = null!;

    public int PublishingId { get; set; }

    public virtual ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();

    public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();

    public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();

    public virtual Publishing Publishing { get; set; } = null!;
}
