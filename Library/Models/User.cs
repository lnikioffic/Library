using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Library.Models;

public partial class User : IModel
{
    [Browsable(false)]
    public int Id { get; set; }

    [DisplayName(@"Имя")]
    public string FirstName { get; set; } = null!;

    [DisplayName(@"Фамилия")]
    public string LastName { get; set; } = null!;

    [DisplayName(@"Отчество")]
    public string? Patronymic { get; set; }

    [DisplayName(@"Читательский")]
    public int Ticket { get; set; }

    [Browsable(false)]
    public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();
}
