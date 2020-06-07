using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApp.API.Models
{
    public class UserRole:IdentityUserRole<int>
    {

        public User User { get; set; }

        public Role Role { get; set; }
    }
}
