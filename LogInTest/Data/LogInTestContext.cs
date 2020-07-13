using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LogInTest.Models;

namespace LogInTest.Data
{
    public class LogInTestContext : DbContext
    {
        public LogInTestContext (DbContextOptions<LogInTestContext> options)
            : base(options)
        {
        }

        public DbSet<LogInTest.Models.User> User { get; set; }
    }
}
