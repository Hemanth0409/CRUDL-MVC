using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDL.Models
{
    public class Trainee
    {
        public int traineeId { get; set; }
        public string traineeName { get; set; }
        public string department { get; set; }
        public int trainerId { get; set; }
    }
}