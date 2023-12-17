using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.ReportModels
{
    public class ReportReturned
    {
        //public Book Book { get; set; } = null!;
        //public User User { get; set; } = null!;

        public string BookTitel { get; set; } = null!;

        public string EstimatedReturnDate { get; set; } = null!;

        public int MissedDays { get; set; }

        public string User { get; set; } = null!;
    }
}
