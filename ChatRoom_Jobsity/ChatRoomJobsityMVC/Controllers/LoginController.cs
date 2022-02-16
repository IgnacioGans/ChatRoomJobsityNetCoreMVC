using ChatRoomJobsityMVC.Models.UsersModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomJobsityMVC.Controllers
{
    public class LoginController : Controller
    {
        const string SessionName = "_Name";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginT(Users data)
        {
            var u = new Repository_users();
            var ua = u.UserList();
            var ue = ua.Where(ua => ua.username.Equals(data.username));
            var up = ue.Where(p => p.password.Equals(data.password));
            var valBool = up.Count();
            if (up.Count() == 1)
            {
                HttpContext.Session.SetString(SessionName, data.username);
                return Redirect("/ChatRoom/Index");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost]
        public JsonResult Login(string data)
        {
            Users dataUser = new Users();
            Users UserObject = dataUser.DataJsonToObject(data);

            var u = new Repository_users();
            var ua = u.UserList();
            var ue = ua.Where(ua => ua.username.Equals(UserObject.username));
            var up = ue.Where(p => p.password.Equals(UserObject.password));
            if (up.Count() == 1)
            {
                var dataResponse = new { 
                    StatusCode = "OK",
                    Msg = "Login Success"
                };
                HttpContext.Session.SetString(SessionName, dataUser.username);
                return Json(dataResponse);
            }
            else
            {
                var dataResponse = new
                {
                    StatusCode = "FAIL",
                    Msg = "Login Fail"
                };

                return Json(dataResponse);
            }
        }
        [HttpPost]
        public JsonResult Test1()
        {
            var dataObj = new
            {
                message = "Testing testing 1"
            };

            return Json(dataObj);
        }
    }
}
