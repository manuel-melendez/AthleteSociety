using AthleteSociety.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AthleteSociety.Infrastructure.Data
{
    public class AthleteSocietyDbContext : DbContext
    {
        public AthleteSocietyDbContext(DbContextOptions<AthleteSocietyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Player> Players { get; set; }
    }
}
