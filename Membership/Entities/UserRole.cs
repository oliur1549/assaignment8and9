using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Membership.Entities
{
    public class UserRole
        : IdentityUserRole<Guid>
    {
       
    }
}
