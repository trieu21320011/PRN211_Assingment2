<<<<<<< HEAD
﻿#nullable disable
=======
﻿using System;
using System.Collections.Generic;
>>>>>>> d2f9827 (CreateOrder)

namespace BusinessObject
{
    public partial class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
        }

        public int Memberid { get; set; }
        public string Email { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
