using System;
using System.Collections.Generic;
using System.ComponentModel;
using Library.Models;

namespace Library.Models;

public partial class Genre: IModel
{
    [Browsable(false)]
    public int Id { get; set; }

    [DisplayName(@"Название")]
    public string Genre1 { get; set; } = null!;

    [Browsable(false)]
    public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
}
