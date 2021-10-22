using GraphQLTodos.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLTodos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<TodoGroup> TodoGroups { get; set; }
    }
}