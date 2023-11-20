using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class AuthorBook : IModel
{
    public int Id { get; set; }

    public int AuthorId { get; set; }

    public int BookId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;
}
