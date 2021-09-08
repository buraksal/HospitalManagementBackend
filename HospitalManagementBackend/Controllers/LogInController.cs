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
            //DB de arama yap
            //eğer varsa
            return Ok("Successful Mail: asd");
        }

        [HttpPost]
        [Route("signin")]
        public ActionResult LogInControl(LogInRequest logInRequest)
        {
            //DB de arama yap
            //eğer varsa
            return Ok("UserType: " + logInRequest.UserType);
        }
    }
}
