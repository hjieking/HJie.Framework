using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HJie.Lib.EECore.Models
{
    [Table("AspNetUser.Test.t")]
    public class AspNetUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }

        public bool IsEnabled { get; set; }
    }
}
