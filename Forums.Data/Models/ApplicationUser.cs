using Microsoft.AspNetCore.Identity;
using System;

namespace Forums.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Rating { get; set; }
        public string ProfileImageurl { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsActive { get; set; }
    }
}
