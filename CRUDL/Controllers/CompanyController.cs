using CRUDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDL.Controllers
{
    public class CompanyController : Controller
    {
        static IList<CompanyProp> companyProps = new List<CompanyProp>
        {
            new CompanyProp(){CompanyName="SharonDb",CompanyEmail="sharondb123@sdb.com",CompanyDescription="Web Development Company",CompanyPhone="9876543210",Id=1}
        };
        // GET: Company
        public ActionResult Details()
        {
            ViewData["companyProps"] = companyProps;
            ViewBag.Skillsets = new List<string>{
            "Creativity",
            "Leadership",
            "Team Work",       
         };
            return View(companyProps);
        }
      
      
    }
}