using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using ChatApp.Model;

namespace ChatApp.DAC
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Chat> Chat { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                        .Property(p=>p.ID)
                        .UseSqlServerIdentityColumn();
        }
    }
}
