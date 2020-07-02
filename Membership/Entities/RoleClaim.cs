using System;

using Microsoft.AspNetCore.Identity;

namespace Membership.Entities
{
    public class RoleClaim
        : IdentityRoleClaim<Guid>
    {
        public RoleClaim()
            : base()
        {

        }
    }
}
