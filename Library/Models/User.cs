using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public bool? Role { get; set; }

    public virtual ICollection<Journal> JournalUserIssueds { get; set; } = new List<Journal>();

    public virtual ICollection<Journal> JournalUserTooks { get; set; } = new List<Journal>();
}
