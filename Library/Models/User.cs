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

    [Browsable(false)]
    public bool? Role { get; set; }

    [Browsable (false)]
    public virtual ICollection<Journal> JournalUserIssueds { get; set; } = new List<Journal>();

    [Browsable(false)]
    public virtual ICollection<Journal> JournalUserTooks { get; set; } = new List<Journal>();

    public User()
    {

    }   
}
