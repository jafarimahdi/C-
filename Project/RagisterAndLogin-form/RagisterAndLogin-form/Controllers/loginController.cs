using Microsoft.AspNetCore.Mvc;
using RagisterAndLogin_form.Models;

namespace RagisterAndLogin_form.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if(userModel.UserName =="BillGates" & userModel.Password == "bigBucks") 
            {
            return View("LoginSuccess", userModel);

            }
            else
            {
                return View("LoginFailure", userModel);
            }
             
        }
    }
}
