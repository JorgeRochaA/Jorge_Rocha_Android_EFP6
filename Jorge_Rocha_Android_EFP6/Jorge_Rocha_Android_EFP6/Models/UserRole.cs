using System;
using System.Collections.Generic;
using System.Text;

namespace Jorge_Rocha_Android_EFP6.Models
{
    public class UserRole
    {
        public UserRole() { }

        public int UserRoleId { get; set; }

        public string UserRole1 { get; set; } = null!;

        public bool IsUserSelectable { get; set; }

        //public virtual ICollection<User> Users { get; } = new List<User>();
    }
}
