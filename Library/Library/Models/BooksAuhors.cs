using System;
using System.Collections.Generic;

namespace Library
{
    public partial class BooksAuhors
    {
        public long Id { get; set; }
        public long? BooksId { get; set; }
        public long? AuthorsId { get; set; }

        public virtual Authors Authors { get; set; }
        public virtual Books Books { get; set; }
    }
}
