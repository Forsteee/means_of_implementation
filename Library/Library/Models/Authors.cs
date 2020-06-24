using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Authors
    {
        public Authors()
        {
            BooksAuhors = new HashSet<BooksAuhors>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<BooksAuhors> BooksAuhors { get; set; }
    }
}
