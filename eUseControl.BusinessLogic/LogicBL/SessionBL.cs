using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interface;
using eUseControl.Models.Entities.General;
using eUseControl.Models.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.LogicBL
{
    public class SessionBL : UserApi, ISession
    {
        public ResponsMSG GetUserSession(USessionData udata)
        {
            return UserSession(udata);
        }

    }
}
