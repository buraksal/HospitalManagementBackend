using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementBackend.Models
{
    public enum UserTypes
    {
        Admin = 1,
        Doctor = 2,
        Nurse = 3,
        Patient = 4
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ssn { get; set; }
        public UserTypes UserType { get; set; }
    }
}
