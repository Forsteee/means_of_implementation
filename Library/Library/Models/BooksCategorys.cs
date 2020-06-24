using System;
using System.Collections.Generic;

namespace Library
{
    public partial class BooksCategorys
    {
        public long Id { get; set; }
        public long? BooksId { get; set; }
        public long? CategorysId { get; set; }

        public virtual Books Books { get; set; }
        public virtual Categorys Categorys { get; set; }
    }
}
