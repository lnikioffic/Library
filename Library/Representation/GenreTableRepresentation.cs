using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Representation
{
    internal class GenreTableRepresentation : ITableRepresentation
    {
        [DisplayName(@"Название")]
        public string Genre { get; }

        [Browsable(false)]
        public Genre RepresentEntity { get; }

        public GenreTableRepresentation(Genre genre)
        {
            RepresentEntity = genre;
            Genre = RepresentEntity.Genre1;
        }
    }
}
