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
        public DbSet<Level> Level { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoryStatus>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<CategoryOfKeyword>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(25);
            
            modelBuilder.Entity<Criterion>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Level>()
                .Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(25);
            
            modelBuilder.Entity<Role>()
                .Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.RoleId)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.UserStatusId)
                .IsRequired();

                
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_contectionString);
        }
    }
}
