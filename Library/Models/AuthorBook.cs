using System;
using System.Collections.Generic;
using Library.Models.Interface;

namespace Library.Models;

public partial class AuthorBook : IModel, ISearchField
{
    public int Id { get; set; }

    public int AuthorId { get; set; }

    public int BookId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;

    public string SearchField
    {
        get
        {
            return $"{Author.SearchField}";
        }
    }
}
