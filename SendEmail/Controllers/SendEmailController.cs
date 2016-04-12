using SendEmail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Configuration;
using SendEmail.Common;

namespace SendEmail.Controllers
{
    public class SendEmailController : Controller
    {
        
        // GET: SendEmail
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmailView(EmployeeModel model)
        {
            try
            {
                //发邮件
               EmailHelper.SendEmail(model.ToEmail, model.EmailSubject, model.EMailBody, model.EmailCC, model.EmailBCC);
            }
            catch (Exception ex)
            {
             ViewBag.ErrorMessage=ex.Message;
            
            }
         
            return View();
        }

        
    }
}