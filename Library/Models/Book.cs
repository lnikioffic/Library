using System;
using System.Collections.Generic;
using System.ComponentModel;
using Library.Models.Interface;

namespace Library.Models;

public partial class Book: IModel, ISearchField
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string PublicationDate { get; set; } = null!;

    public int PublishingId { get; set; }

    public virtual ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();

    public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();

    public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();

    public virtual Publishing Publishing { get; set; } = null!;

    [Browsable(false)]
    public string SearchField
    {
        get
        {
            return $"{Title} {AuthorBooks}";
        }
    }

    public override string ToString()
    {
        return Title;
    }
}
