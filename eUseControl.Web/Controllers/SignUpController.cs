using eUseControl.BusinessLogic.Interface;
using eUseControl.Web.Models;
using eUseControl.Models.Entities.General;
using eUseControl.Models.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic;
using System.Web.UI.WebControls;

namespace eUseControl.Web.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ISession _session;
        public SignUpController()
        {
            // var bl = new BusinessLogic();
            BusinessLogic.BusinessLogic bl = new BusinessLogic.BusinessLogic();
            _session = bl.GetSessionBL();
        }



        // GET: SignUp
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Auth(ULogin login)
        {
            
                USessionData udata = new USessionData();
                udata.Credential = login.Credential;
                udata.Password = login.Password;
                udata.SessionDate = DateTime.Now;


                ResponsMSG status = _session.GetUserSession(udata);
               
                if (status.Status)
               {
                HttpCookie httpCookie = _session.GenCookie(udata.Credential);
                HttpCookie cookie = httpCookie;
                ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("SignUp", "SignUp");
                }


            
        }
    }
}