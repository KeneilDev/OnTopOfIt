using OnTopOfIt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTopOfIt.Infrastructure
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            :base (options)
        {

        }

        public DbSet<TodoItems> TodoItems { get; set; }
    }
}
