using CRUDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDL.Controllers
{
    public class TraineeController : Controller
    {
        // GET: Trainee
        public ActionResult TraineeDetails()
        {
            Trainee trainee = new Trainee()
            {
                traineeId = 100,
                traineeName = "Sharon",
                department = "Php",
                trainerId = 1,
            };
            return View(trainee);
        }
    }
}