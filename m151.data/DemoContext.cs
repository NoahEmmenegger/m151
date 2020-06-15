using m151.data.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace m151.data
{
    public class DemoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public DemoContext(DbContextOptions<DemoContext> options)
            :base(options)
        { }
    }
}
