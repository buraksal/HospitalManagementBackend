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
    [Route("login")]
    public class LogInController : ControllerBase
    {
        [HttpGet]
        public ActionResult LogInControl()
        {
            return Ok("Successful Mail: asd");
        }

        [HttpPost]
        [Route("signin")]
        public ActionResult LogInControl(LogInRequest logInRequest)
        {
            using (var context = new HospitalManagementContext())
            {
                var userList = (from users in context.Users orderby users.Email select users).ToList<User>();
                foreach (var user in userList)
                {
                    if (logInRequest.Email.Equals(user.Email))
                    {
                        if (logInRequest.Password.Equals(user.Password))
                        {
                            return Ok("Welcome:" + user.Name + " type: " + user.UserType);
                        }
                        return Ok("Email and Passwords does not match");
                    }
                }
                return Ok("Your Email is not on our database");


            }
        }
    }
}
