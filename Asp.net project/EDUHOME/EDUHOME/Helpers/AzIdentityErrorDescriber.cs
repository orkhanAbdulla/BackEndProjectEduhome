using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Helpers
{
    public class AzIdentityErrorDescriber:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code=nameof(PasswordRequiresLower),
                Description="kiçik hərif istifadə olunmalıdır!"
            };
        }
    }
}
