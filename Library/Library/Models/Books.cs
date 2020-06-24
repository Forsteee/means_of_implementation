using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Books
    {
        public Books()
        {
            BooksAuhors = new HashSet<BooksAuhors>();
            BooksCategorys = new HashSet<BooksCategorys>();
            BooksGenrys = new HashSet<BooksGenrys>();
            RecordsBooks = new HashSet<RecordsBooks>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string YPublishing { get; set; }
        public long? PublishingsId { get; set; }

        public virtual Publishings Publishings { get; set; }
        public virtual ICollection<BooksAuhors> BooksAuhors { get; set; }
        public virtual ICollection<BooksCategorys> BooksCategorys { get; set; }
        public virtual ICollection<BooksGenrys> BooksGenrys { get; set; }
        public virtual ICollection<RecordsBooks> RecordsBooks { get; set; }
    }
}
