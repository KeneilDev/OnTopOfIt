using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnTopOfIt.Models;

namespace OnTopOfIt.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the OnTopOfItUser class
    public class OnTopOfItUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<TodoItems> TodoList { get; set; }
    }
}
