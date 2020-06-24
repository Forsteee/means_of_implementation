using System;
using System.Collections.Generic;

namespace Library
{
    public partial class EmploymentsUsers
    {
        public long Id { get; set; }
        public long? UsersId { get; set; }
        public long? EmpoymentsId { get; set; }

        public virtual Employments Empoyments { get; set; }
        public virtual Users Users { get; set; }
    }
}
