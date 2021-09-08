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
            //DB de SSN arama yap
            //eğer yoksa
            //ekle
            return Ok("Successful Mail:" + request.Email + " and pw:" + request.Password + " type: " + request.UserType);
        }


    }
}
