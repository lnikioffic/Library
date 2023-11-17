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

    public int UserId { get; set; }

    public int StaffId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Staff Staff { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
