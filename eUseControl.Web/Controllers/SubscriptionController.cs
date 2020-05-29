using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic.Interface;
using eUseControl.Web.Models;
using eUseControl.Models.Entities.General;
using eUseControl.Models.Entities.User;


namespace eUseControl.Web.Controllers
{
    public class SubscriptionController : Controller
    {
        // GET: Subscription
        public ActionResult Subscription()
        {
             
            ULoginData udata = new ULoginData();
            udata.Username =  udata.Username;
            udata.Products = new List<string> { "Bridge to Terab", "The Heat", "Blue Jay", "Jumanji", "Spies in Disg" };
            return View(udata);
        }
        public ActionResult Product()
        {
            var product = Request.QueryString["p"];

            ULoginData udata = new ULoginData();
            udata.Username = "Person";
            udata.SingleProduct = product;

            return View(udata);
        }
        [HttpPost]
        public ActionResult Product(string btn)
        {
            return RedirectToAction("Product", "Subscription", new { @p = btn });
        }
        
    }
}