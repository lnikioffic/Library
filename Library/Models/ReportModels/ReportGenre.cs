using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.ReportModels
{
    public class ReportGenre
    {
        public string Name { get; set; } = null!;
        public int CountBook { get; set; }
        public double Popularity { get; set; }
    }
}
