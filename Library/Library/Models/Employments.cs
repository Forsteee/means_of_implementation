using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Employments
    {
        public Employments()
        {
            EmploymentsUsers = new HashSet<EmploymentsUsers>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<EmploymentsUsers> EmploymentsUsers { get; set; }
    }
}
