using System;
using Microsoft.EntityFrameworkCore;
using tarjetacredito_csharp.Models;

namespace tarjetacredito_csharp
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<CreditCard> CreditCard { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}
