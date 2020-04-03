using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class ULoginData
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime SessionDate { get; internal set; }
    }
}