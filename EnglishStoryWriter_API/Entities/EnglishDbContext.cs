using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace EnglishStoryWriter_API.Entities
{  
    public class EnglishDbContext : DbContext
    {
        private readonly string _contectionString;
        public EnglishDbContext(IConfiguration configuration)
        {
            _contectionString = configuration.GetConnectionString("EnglishDBConnection");
        }
        public DbSet<StoryStatus> StoryStatus { get; set; }
        public DbSet<CategoryOfKeyword> CategoryOfKeyword { get; set; }
        public DbSet<Criterion> Criterion{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoryStatus>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(25);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_contectionString);
        }
    }
}
