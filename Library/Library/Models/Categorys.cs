using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Categorys
    {
        public Categorys()
        {
            BooksCategorys = new HashSet<BooksCategorys>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BooksCategorys> BooksCategorys { get; set; }
    }
}
