using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HJie.Lib.EECore.Models
{
    [Table("AspNetUser")]
    public class AspNetUser: EntityBase
    {
        public string Name { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }

        public bool IsEnabled { get; set; }
    }
}
