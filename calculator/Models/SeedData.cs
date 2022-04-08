using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using calculator.Data;
using System;
using System.Linq;

namespace calculator.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new calculatorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<calculatorContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Name = "John",
                        Results = "233 431 19.2"
                    }, new User
                    {
                        Name = "Mary",
                        Results = ""
                    }, new User
                    {
                        Name = "George Bush",
                        Results = "3 234423 234.52 777"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}