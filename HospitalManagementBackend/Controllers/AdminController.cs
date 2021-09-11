using HospitalManagementBackend.Context;
using HospitalManagementBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementBackend.Controllers
{
    [ApiController]
    [Route("admin")]
    public class AdminController : Controller
    {
        [HttpGet]
        [Route("getUserList")]
        public List<User> GetUserList()
        {
            using (var context = new HospitalManagementContext())
            {
                var userList = (from user in context.Users orderby user.Name select user).ToList<User>();
                return userList;
            }
        }
    }
}
