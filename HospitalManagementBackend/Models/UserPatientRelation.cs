using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementBackend.Models
{
    public class UserPatientRelation
    {
        [Key]
        public Guid UserId { get; set; }
        public Guid PatientId { get; set; }
        public string Complaint { get; set; }
        public Guid ApproverId { get; set; }

    }
}
