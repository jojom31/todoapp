using Microsoft.EntityFrameworkCore;
using TodoApp.Core;

namespace TodoApp.DAL
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> Todos { get; set; }


        public TodoDbContext() : base()         {          }
        public TodoDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=041103;Database=TodoApp");
        }


    }

    
}
