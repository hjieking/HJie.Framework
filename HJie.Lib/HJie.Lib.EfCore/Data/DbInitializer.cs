using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HJie.Lib.EfCore
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.AspNetUsers.Any())
            {
                return; // DB has been seeded 
            }

            context.AspNetUsers.Add(new AspNetUser { Name = "jesse" });
            context.SaveChanges();
        }
    }
}
