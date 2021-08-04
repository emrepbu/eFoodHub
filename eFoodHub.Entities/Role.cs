using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eFoodHub.Entities
{
    public class Role: IdentityRole<int>
    {
        public string Description { get; set; }
        
    }
}
