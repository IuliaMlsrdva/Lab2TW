using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Models.Entities.General;
using eUseControl.Models.Entities.User;

namespace eUseControl.BusinessLogic.Core
{
  public  class UserApi
    {
        public ResponsMSG UserSession(USessionData udata)
        {
            return new ResponsMSG();
        }
    }
}
