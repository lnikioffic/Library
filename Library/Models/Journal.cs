using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Journal: IModel
{
    public int Id { get; set; }

    public DateOnly DateOfIssued { get; set; }

    public DateOnly EstimatedReturnDate { get; set; }

    public DateOnly ActualReturnDate { get; set; }

    public int BookId { get; set; }

    public int UserTookId { get; set; }

    public int UserIssuedId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual User UserIssued { get; set; } = null!;

    public virtual User UserTook { get; set; } = null!;
}
