using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Models.Entities.User
{
   public class USessionData
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime SessionDate { get; set; }
    }
}
