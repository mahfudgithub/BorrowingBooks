using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BorrowBooks.Model
{
    public class Transaction
    {
        [Key,StringLength(10)]
        public string BorrowedId { get; set; }
        public string BookCode { get; set; }
        public string MemberCode { get; set; }
        public DateTime? BorrowedDate { get; set; }
        public DateTime? ReturnLimitDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
