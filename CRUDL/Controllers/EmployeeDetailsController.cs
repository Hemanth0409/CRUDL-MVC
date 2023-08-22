using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDL.Models;
using CRUDL.ViewModels;
namespace CRUDL.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        // GET: EmployeeDetails
        public ActionResult Employee()
        {
            Trainee trainee = new Trainee()
            {
                traineeId = 100,
                traineeName="Sharon",
                department="Php",
                trainerId=1,
            };
            Trainer trainer = new Trainer()
            {
                trainerId = 1,
                trainerName="Darshan",
                department="Php"

            };
            EmployeeDetails empDetails = new EmployeeDetails()
            {
                Trainee=trainee,
                Trainer=trainer,
            };
            return View(empDetails);
        }
    }
}