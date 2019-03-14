using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace Store.Models.DbModels
{
    public class CustomUser : IdentityUser
    {
        public DateTime? LastVisit { get; set; }

        //navigation property
        public virtual ICollection<Account> Accounts { get; set; }
    }
}