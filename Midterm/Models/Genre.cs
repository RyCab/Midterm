using System;
using System.Collections.Generic;

#nullable disable

namespace Midterm.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        public int GenreId { get; set; }
        public string GenreType { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
