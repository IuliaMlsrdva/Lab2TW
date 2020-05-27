using eUseControl.Models.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Models.Entities.User
{
   public class USessionData
    {
        public string Credential { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
       
        public string LoginIP { get; set; }
        public DateTime SessionDate { get; set; }



        
    }
}
