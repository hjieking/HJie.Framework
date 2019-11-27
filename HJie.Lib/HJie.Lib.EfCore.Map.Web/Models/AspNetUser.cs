using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HJie.Lib.EfCore.Map.Web.Models
{
    [Table("AspNetUser.User")]
    public class AspNetUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }

        public bool IsEnabled { get; set; }
    }
}
