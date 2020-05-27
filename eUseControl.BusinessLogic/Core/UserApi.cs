using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinessLogic.DBModel.Seed;
using eUseControl.Models.Entities.General;
using eUseControl.Models.Entities.User;
using eUseControl.BusinessLogic.DBModel;
using eUseControl.Models.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace eUseControl.BusinessLogic.Core
{
    public class UserApi
    {
      
    
        internal ResponsMSG UserSession(USessionData udata) 
        {
            UDbTable user;

            using (var db = new UserContext())
            {
              
               user = db.Users.FirstOrDefault(u => u.Username == udata.Credential);
            }

            using (var db = new UserContext())
            {
                user = (from u in db.Users where u.Username == udata.Credential select u).FirstOrDefault();
            }


            if (user != null)
            {

            }


            return new ResponsMSG();
        }

    }
}
