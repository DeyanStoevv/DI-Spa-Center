using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spacentar.Data
{
    public class ApplicationDbContext : IdentityDbContext<Client>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        //public virtual DbSet<Client>Clients { get; set; }
        public virtual DbSet<Procedure> Procedures { get; set; }
        public virtual DbSet<ProgramName>ProgramNames{ get; set; }
        public virtual DbSet<Rezervation> Rezervations { get; set; }
    }
}
