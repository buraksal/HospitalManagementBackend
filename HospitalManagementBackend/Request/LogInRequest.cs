using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementBackend.Request
{
    public class LogInRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
