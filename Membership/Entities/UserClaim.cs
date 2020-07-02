using System;

using Microsoft.AspNetCore.Identity;

namespace Membership.Entities
{
    public class UserClaim
        : IdentityUserClaim<Guid>
    {
        public UserClaim()
            : base()
        {

        }
    }
}
