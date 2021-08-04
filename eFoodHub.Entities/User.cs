using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace eFoodHub.Entities
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        
        [NotMapped]
        public string[] Roles { get; set; }

    }
}
