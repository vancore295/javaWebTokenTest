using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth0_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth0_Test.DBContext
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
