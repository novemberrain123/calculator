#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using calculator.Models;

namespace calculator.Data
{
    public class calculatorContext : DbContext
    {
        public calculatorContext (DbContextOptions<calculatorContext> options)
            : base(options)
        {
        }

        public DbSet<calculator.Models.User> User { get; set; }
    }
}
