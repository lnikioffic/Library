using Library.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Representation
{
    internal interface IRepresentationFabric<T>
        where T: class, IModel
    {
        ITableRepresentation CreateTableRepresentation(T tableModel);
    }
}
