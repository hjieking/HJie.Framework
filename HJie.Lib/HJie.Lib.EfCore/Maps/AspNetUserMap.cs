using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HJie.Lib.EfCore
{
    public class AspNetUserMap : EntityMappingConfiguration<AspNetUser>
    {
        public override void Map(EntityTypeBuilder<AspNetUser> b)
        {
            //b.ToTable("AspNetUser");
            b.HasKey(u => u.Id);
            b.Property(u => u.AppKey).HasMaxLength(30);
        }
    }
}
