
using MailKit;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Web.Mvc;
using System.Linq;
using System.Web.Security;
using Newtonsoft.Json;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            return View();
        }

    }
}
