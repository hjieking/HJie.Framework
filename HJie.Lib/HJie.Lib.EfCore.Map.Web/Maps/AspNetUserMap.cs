using HJie.Lib.EfCore.Map.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HJie.Lib.EfCore.Map.Web.Maps
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
