using System;
using System.Collections.Generic;
using System.Text;

namespace Jorge_Rocha_Android_EFP6.Models
{
    public class UserStatus
    {
        public UserStatus() { }

        public int UserStatusId { get; set; }

        public string Status { get; set; } = null!;

        //public virtual ICollection<User> Users { get; } = new List<User>();
    }
}
