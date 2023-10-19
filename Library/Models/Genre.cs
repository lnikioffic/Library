using System;
using System.Collections.Generic;
using Library.Models;

namespace Library.Models;

public partial class Genre: IModel
{
    public int Id { get; set; }

    public string Genre1 { get; set; } = null!;

    public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
}
