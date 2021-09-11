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
    [Route("signup")]
    public class SignUpController : Controller
    {

        [HttpGet]
        public ActionResult SignUpControl()
        {
            //DB de arama yap
            //eğer varsa
            return Ok("Successful Mail: asd");
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(SignUpRequest request)
        {
            using (var context = new HospitalManagementContext())
            {
                Boolean alreadyExists = false;
                var userList = (from users in context.Users orderby users.Ssn select users).ToList<User>();
                foreach (var user in userList)
                {
                    if (request.Ssn.Equals(user.Ssn))
                    {
                        alreadyExists = true;
                    }
                }
                if (!alreadyExists)
                {
                    User newUser = new User()
                    {
                        Id = Guid.NewGuid(),
                        Name = request.Name,
                        Password = request.Password,
                        Email = request.Email,
                        Ssn = request.Ssn,
                        UserType = (UserTypes)request.UserType
                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    return Ok("Successfully added Mail:" + request.Email + " and pw:" + request.Password + " type: " + request.UserType);
                } else
                {
                    return Ok("User with SSN: "+request.Ssn + " already exists in database");
                }
            }
        }
    }
}
