﻿using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class BookGenre : IModel
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int GenreId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;
}
