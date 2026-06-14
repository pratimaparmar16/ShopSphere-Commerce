using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ShopSphere.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName
        {
            get;
            set;
        } = string.Empty;

        public string LastName
        {
            get;
            set;
        } = string.Empty;
    }
}
