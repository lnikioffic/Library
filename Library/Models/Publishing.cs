using System;
using System.Collections.Generic;
using System.ComponentModel;
using Library.Models;

namespace Library.Models;

public partial class Publishing : IModel
{
    [Browsable(false)]
    public int Id { get; set; }

    [DisplayName(@"Название")]
    public string Name { get; set; } = null!;

    [DisplayName(@"Адресс")]
    public string Address { get; set; } = null!;

    [Browsable(false)]
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
