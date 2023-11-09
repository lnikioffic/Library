using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Library.Models;

public partial class Book: IModel
{
    [Browsable(false)]
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string PublicationDate { get; set; } = null!;

    [Browsable(false)]
    public int PublishingId { get; set; }

    [DisplayName(@"Жанры")]
    public virtual ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();

    public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();

    public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();

    public virtual Publishing Publishing { get; set; } = null!;

    [Browsable(false)]
    public Book present { get; }

    public Book()
    {
        //AuthorBooks = present.AuthorBooks.ToList();
    }
}
