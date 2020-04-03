using eUseControl.BusinessLogic.Interface;
using eUseControl.Web.Models;
using eUseControl.Models.Entities.General;
using eUseControl.Models.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace eUseControl.Web.Controllers
{
    public class SignUpController : Controller
    {
        public readonly ISession _session;
        public SignUpController()
        {
            BusinessLogic.BusinessLogic bl = new BusinessLogic.BusinessLogic();
            _session = bl.GetSessionBL();
        }
        // GET: SignUp
        public ActionResult SignUp(ULoginData data)
        {
            USessionData udata = new USessionData();
            udata.UserName = data.UserName;
            udata.UserPassword = data.UserPassword;
            udata.SessionDate = DateTime.Now;

            ResponsMSG status = _session.GetUserSession(udata);
           
            return View();
        }
    }
}