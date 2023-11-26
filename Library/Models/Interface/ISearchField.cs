using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Interface
{
    internal interface ISearchField
    {
        [Browsable(false)]
        public string SearchField { get; }
    }
}
