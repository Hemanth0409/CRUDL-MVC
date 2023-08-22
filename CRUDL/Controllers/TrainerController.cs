using CRUDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDL.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult TrainerDetails()
        {
            Trainer trainer = new Trainer()
            {
                trainerId = 1,
                trainerName = "Darshan",
                department = "Php"

            };
            return View(trainer);
        }
    }
}