using System;
using System.Collections.Generic;
using Library.Models;

namespace Library.Models;

public partial class Publishing
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
