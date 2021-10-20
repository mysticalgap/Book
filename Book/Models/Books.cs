using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int AuthorId { get; set; }
    }
}
