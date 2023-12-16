using System;
using System.Collections.Generic;
using System.ComponentModel;
using Library.Models.Interface;

namespace Library.Models;

public partial class Author : IModel, ISearchField
{
    [Browsable(false)]
    public int Id { get; set; }

    [DisplayName(@"Фамилия")]
    public string LastName { get; set; } = null!;

    [DisplayName(@"Имя")]
    public string FirstName { get; set; } = null!;

    [DisplayName(@"Отчество")]
    public string? Patronymic { get; set; }

    [Browsable(false)]
    public virtual ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();

    [Browsable(false)]
    public string SearchField
    {
        get
        {
            return $"{LastName} {FirstName}";
        }
    }

    public override string ToString()
    {
        return LastName;
    }

    public string ToStringNew()
    {
        return $"{LastName} {FirstName} {Patronymic}";
    }
}
