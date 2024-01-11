using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenProject.Models;

namespace ExamenProject.Data
{
    public class ExamenProjectContext : DbContext
    {
        public ExamenProjectContext (DbContextOptions<ExamenProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ExamenProject.Models.Member> Members { get; set; }
        public DbSet<ExamenProject.Models.Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable(nameof(Member));
            modelBuilder.Entity<Book>().ToTable(nameof(Book));

            modelBuilder.Entity<Book>()
            .HasOne(b => b.Member)
            .WithMany(m => m.Books)
            .HasForeignKey(b => b.MemberId);
        }
    }
}
