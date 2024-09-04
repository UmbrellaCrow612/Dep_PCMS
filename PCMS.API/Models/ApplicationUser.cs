﻿using Microsoft.AspNetCore.Identity;

namespace PCMS.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
