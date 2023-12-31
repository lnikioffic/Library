﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Library.Models.Interface;

namespace Library.Models;

public partial class Journal: IModel, ISearchField
{
    [Browsable(false)]
    public int Id { get; set; }

    [DisplayName(@"Книга")]
    public virtual Book Book { get; set; } = null!;

    [DisplayName(@"Получатель")]
    public virtual User User { get; set; } = null!;

    [DisplayName(@"Дата выдачи")]
    public DateOnly DateOfIssued { get; set; }

    [DisplayName(@"Предполагаемая дата возврата")]
    public DateOnly EstimatedReturnDate { get; set; }

    [DisplayName(@"Дата возврата")]
    public DateOnly? ActualReturnDate { get; set; }

    [Browsable(false)]
    public int BookId { get; set; }

    [Browsable(false)]
    public int UserId { get; set; }

    [Browsable(false)]
    public int StaffId { get; set; }

    [DisplayName(@"Выдающий")]
    public virtual Staff Staff { get; set; } = null!;

    [Browsable(false)]
    public string SearchField
    {
        get
        {
            return $"{User.SearchField} {Book.SearchField}";
        }
    }
}
