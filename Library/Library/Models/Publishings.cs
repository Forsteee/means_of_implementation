﻿using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Publishings
    {
        public Publishings()
        {
            Books = new HashSet<Books>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
