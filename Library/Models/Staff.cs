using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models.Interface;

namespace Library.Models
{
    public partial class Staff : IModel, ISearchField
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
        public int RoleId { get; set; }

        [Browsable(false)]
        public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();

        [DisplayName(@"Должность")]
        public virtual Role Role { get; set; } = null!;

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
            return LastName + " " + FirstName;
        }
    }
}
