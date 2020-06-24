using System;
using System.Collections.Generic;

namespace Library
{
    public partial class BooksGenrys
    {
        public long Id { get; set; }
        public long? BooksId { get; set; }
        public long? GenrysId { get; set; }

        public virtual Books Books { get; set; }
        public virtual Genrys Genrys { get; set; }
    }
}
