using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool? Active { get; set; }
        public string Fullname { get; set; }
        public int? RolesId { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Role Roles { get; set; }
    }
}
