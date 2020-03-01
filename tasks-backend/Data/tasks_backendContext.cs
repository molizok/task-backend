using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tasks_backend;

namespace tasks_backend.Data
{
    public class tasks_backendContext : DbContext
    {
        public tasks_backendContext (DbContextOptions<tasks_backendContext> options)
            : base(options)
        {
        }

        public DbSet<tasks_backend.Task> Task { get; set; }
    }
}
