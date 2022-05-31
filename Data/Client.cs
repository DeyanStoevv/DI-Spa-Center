using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Spacentar.Data
{
    public class Client:IdentityUser
    { 
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public string Tel { get; set; }

        public virtual ICollection<Rezervation>Rezervations { get; set; }

    }
}
