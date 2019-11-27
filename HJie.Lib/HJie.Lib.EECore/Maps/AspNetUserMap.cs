using HJie.Lib.EECore.Models;
using HJie.Lib.EECore.Unit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HJie.Lib.EECore.Maps
{
    public class AspNetUserMap : EntityMappingConfiguration<AspNetUser>
    {
        //public AspNetUserConfig(ModelBuilder builder)
        //{
        //    var b= builder.Entity<AspNetUser>();
        //}
        public override void Map(EntityTypeBuilder<AspNetUser> b)
        {
            b.HasKey(u => u.Id);
            b.Property(u => u.AppKey).HasMaxLength(30).IsRequired();
        }
    }
}
