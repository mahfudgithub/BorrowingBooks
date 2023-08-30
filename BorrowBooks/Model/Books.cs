using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowBooks.Model
{
    public class Books
    {
        [Key,StringLength(10)]
        public string Code { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [StringLength(100)]
        public string Author { get; set; }
        public int Stock { get; set; }
    }
}
