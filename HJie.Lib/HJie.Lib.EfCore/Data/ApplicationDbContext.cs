using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HJie.Lib.EfCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AspNetUser>()
            //.ToTable("AspNetUser");

            base.OnModelCreating(modelBuilder);
            //注入ModelMap对象
            modelBuilder.AddEntityConfigurationsFromAssembly(Assembly.Load("HJie.Lib.EfCore"));
        }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
