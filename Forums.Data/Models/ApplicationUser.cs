﻿using Microsoft.AspNetCore.Identity;
using System;

namespace Forums.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public string UserDescription { get; set; }
        public string ProfileImageUrl { get; set; }
        public int Rating { get; set; }
        public bool IsActive { get; set; }
        public DateTime MemberSince { get; set; }
    }
}
