using HJie.Lib.EECore.Models;
using HJie.Lib.EECore.Unit;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HJie.Lib.EECore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AspNetUser>(b =>
            {
                b.ToTable("AspNetUser");
            });
            // 在 OnModelCreating 方法中加入以下代码
            builder.ExecuteConfigurations("存放实体配置的程序集名称");
            base.OnModelCreating(builder);
        }
    }
}
