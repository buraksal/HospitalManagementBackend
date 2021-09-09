using HospitalManagementBackend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementBackend.Context
{
    public class HospitalManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<UserPatientRelation> Relations { get; set; }
        
    }
}
