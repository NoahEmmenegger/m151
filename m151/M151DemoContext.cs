using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ch.gibz.m151.demo.api.Model;
using Microsoft.EntityFrameworkCore;

namespace ch.gibz.m151.demo.api
{

    public class M151DemoContext : DbContext
    {
        public M151DemoContext(DbContextOptions<M151DemoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
        public DbSet<Test> Grade { get; set; }
    }
}
