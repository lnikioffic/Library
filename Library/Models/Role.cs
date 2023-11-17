using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public partial class Role : IModel
    {
        public int Id { get; set; }

        public string NameRole { get; set; } = null!;

        public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();

        public override string ToString()
        {
            return NameRole;
        }
    }
}
