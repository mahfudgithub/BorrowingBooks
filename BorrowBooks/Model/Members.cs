using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowBooks.Model
{
    public class Members
    {
        [Key,StringLength(5)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime? PenaltyDateFrom { get; set; }
        public DateTime? PenaltyDateTo { get; set; }
    }
}
