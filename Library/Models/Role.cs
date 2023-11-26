using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models.Interface;

namespace Library.Models
{
    public partial class Role : IModel, ISearchField
    {
        public int Id { get; set; }

        public string NameRole { get; set; } = null!;

        public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();

        [Browsable(false)]
        public string SearchField
        {
            get
            {
                return $"{NameRole}";
            }
        }

        public override string ToString()
        {
            return NameRole;
        }
    }
}
