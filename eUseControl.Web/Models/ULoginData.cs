using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class ULoginData
    {
        
        public string Username { get; internal set; }
        public string Password { get; set; }
        public string Credential { get; set; }
        public string LoginIp { get; set; }
        public DateTime SessionDate { get; internal set; }
    }
}