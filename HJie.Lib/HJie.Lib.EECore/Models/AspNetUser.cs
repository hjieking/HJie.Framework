using System;
using System.Collections.Generic;
using System.Text;

namespace HJie.Lib.EECore.Models
{
    public class AspNetUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }

        public bool IsEnabled { get; set; }
    }
}
