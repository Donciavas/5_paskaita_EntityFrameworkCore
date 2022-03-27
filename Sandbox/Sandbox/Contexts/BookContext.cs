using Microsoft.EntityFrameworkCore;
using Sandbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Contexts
{
    internal class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=localhost;Database=Sandbox;Trusted_Connection=True;");
    }
}
