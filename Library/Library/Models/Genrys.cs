using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Genrys
    {
        public Genrys()
        {
            BooksGenrys = new HashSet<BooksGenrys>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BooksGenrys> BooksGenrys { get; set; }
    }
}
