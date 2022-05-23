using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Models
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        { }
        
        public DbSet<User> User { get; set; }

        public DbSet<Book> Book { get; set; }
    }

}