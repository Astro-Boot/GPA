﻿using Microsoft.AspNetCore.Identity;

namespace GPA.Common.Entities.Security
{
    public class GPAUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<GPAUserRole> UserRoles { get; set; }
        public ICollection<GPAUserToken> UserTokens { get; set; }
        public ICollection<GPAUserLogin> UserLogins { get; set; }
    }
}