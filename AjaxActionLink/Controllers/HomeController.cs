using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxActionLink.Models;

namespace AjaxActionLink.Controllers
{
    public class HomeController : Controller
    {

        EmployeeDBEntities db = new EmployeeDBEntities();


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllEmployee()
        {
           var data= db.EmployeeTable.ToList();
            return PartialView("_AllEmployee",data);
        }






    }
}