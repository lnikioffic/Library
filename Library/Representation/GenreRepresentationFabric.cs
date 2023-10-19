using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Representation
{
    internal class GenreRepresentationFabric : IRepresentationFabric<Genre>
    {
        public ITableRepresentation CreateTableRepresentation(Genre tableModel)
        {
            return new GenreTableRepresentation(tableModel);
        }
    }
}
