using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Users
    {
        public Users()
        {
            EmploymentsUsers = new HashSet<EmploymentsUsers>();
            RecordsBooks = new HashSet<RecordsBooks>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<EmploymentsUsers> EmploymentsUsers { get; set; }
        public virtual ICollection<RecordsBooks> RecordsBooks { get; set; }
    }
}
