﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementBackend.Controllers
{
    public class NurseRequest
    {
        public string Name { get; set; }
        public string Ssn { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Complaint { get; set; }
        public string CreatedBy { get; set; }
    }
}