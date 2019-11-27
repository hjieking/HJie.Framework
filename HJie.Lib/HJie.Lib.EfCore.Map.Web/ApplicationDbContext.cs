using HJie.Lib.EfCore.Map.Web.Maps;
using HJie.Lib.EfCore.Map.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HJie.Lib.EfCore.Map.Web
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
            modelBuilder.AddEntityConfigurationsFromAssembly(Assembly.Load("HJie.Lib.EfCore.Map.Web"));
        }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
