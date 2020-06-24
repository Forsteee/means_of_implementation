using System;
using System.Collections.Generic;
using System.Collections;
using NpgsqlTypes;

namespace Library
{
    public partial class RecordsBooks
    {
        public long Id { get; set; }
        public long? BooksId { get; set; }
        public long? UsersId { get; set; }
        public DateTime? DateDrop { get; set; }
        public NpgsqlRange<DateTime>? TimeToDrop { get; set; }
        public BitArray CheckGive { get; set; }

        public virtual Books Books { get; set; }
        public virtual Users Users { get; set; }
    }
}
