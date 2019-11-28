using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HJie.Lib.EfCore
{
    public class SysUserMap : EntityMappingConfiguration<SysUser>
    {
        public override void Map(EntityTypeBuilder<SysUser> b)
        {
            
        }
    }
}
