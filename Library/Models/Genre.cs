using System;
using System.Collections.Generic;
using System.ComponentModel;
using Library.Models.Interface;

namespace Library.Models;

public partial class Genre: IModel, ISearchField
{
    [Browsable(false)]
    public int Id { get; set; }

    [DisplayName(@"Название")]
    public string Genre1 { get; set; } = null!;

    [Browsable(false)]
    public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();

    [Browsable(false)]
    public string SearchField
    {
        get
        {
            return Genre1;
        }
    }

    public override string ToString()
    {
        return Genre1;
    }
}
