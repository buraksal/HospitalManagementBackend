using HospitalManagementBackend.Context;
using HospitalManagementBackend.Models;
using HospitalManagementBackend.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementBackend.Controllers
{
    [ApiController]
    [Route("doctor")]
    public class DoctorController : Controller
    {
        

        [HttpGet]
        [Route("getPatientList")]
        public List<Patient> GetPatientList()
        {
            using (var context = new HospitalManagementContext())
            {
                var patientList = (from patient in context.Patients orderby patient.Name select patient).ToList<Patient>();
                return patientList;
            }
        }

        [HttpPost]
        [Route("createpatient")]
        public IActionResult CreatePatient(DoctorRequest request)
        {
            using (var context = new HospitalManagementContext())
            {
                Boolean alreadyExists = false;
                var patientList = (from patient in context.Patients orderby patient.Ssn select patient).ToList<Patient>();
                foreach (var patient in patientList)
                {
                    if (request.Ssn.Equals(patient.Ssn))
                    {
                        alreadyExists = true;
                    }
                }
                if (!alreadyExists)
                {
                    Patient newPatient = new Patient()
                    {
                        Id = Guid.NewGuid(),
                        Name = request.Name,
                        Password = request.Password,
                        Email = request.Email,
                        Ssn = request.Ssn,
                        Complaint = request.Complaint,
                        CreatedBy = request.CreatedBy
                    };
                    context.Patients.Add(newPatient);
                    context.SaveChanges();
                    return Ok("Successfully added Mail:" + request.Email + " and pw:" + request.Password);
                }
                else
                {
                    return Ok("Patient with SSN: " + request.Ssn + " already exists in database");
                }
            }
        }


        [HttpPost]
        [Route("getPatient")]
        public Patient GetPatient(DoctorRequest request)
        {
            using (var context = new HospitalManagementContext())
            {
                var patientList = (from patient in context.Patients orderby patient.Ssn select patient).ToList<Patient>();
                foreach (var patient in patientList)
                {
                    if (request.Ssn.Equals(patient.Ssn))
                    {
                        return patient;
                    }
                }
                return null;
            }
        }

        [HttpPut]
        [Route("updatePatient")]
        public IActionResult UpdatePatient(DoctorRequest request)
        {
            using (var context = new HospitalManagementContext())
            {
                var patientList = (from patient in context.Patients orderby patient.Ssn select patient).ToList<Patient>();
                foreach (var patient in patientList)
                {
                    if (request.Ssn.Equals(patient.Ssn))
                    {
                        patient.Name = request.Name;
                        patient.Email = request.Email;
                        patient.Password = request.Password;
                        patient.Complaint = request.Complaint;
                        patient.Ssn = request.Ssn;
                        patient.CreatedBy = request.CreatedBy;
                        context.SaveChanges();
                        return Ok("Updated Successfully");
                    }
                }
                return Ok("Such a patient does not exist");
            }
        }

        [HttpDelete]
        [Route("deletePatient")]
        public IActionResult DeletePatient(DoctorRequest request)
        {
            using (var context = new HospitalManagementContext())
            {
                var patientList = (from patient in context.Patients orderby patient.Ssn select patient).ToList<Patient>();
                foreach (var patient in patientList)
                {
                    if (request.Ssn.Equals(patient.Ssn))
                    {
                        context.Patients.Remove(patient);
                        context.SaveChanges();
                        return Ok("Successfully Deleted Patient:" + patient.Name);
                    }
                }
                return Ok("Such patient does not exist");
            }
        }

    }
}
