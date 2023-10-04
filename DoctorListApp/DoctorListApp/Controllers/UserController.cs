using BusinessLayer.Interfaces;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorListApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness userBusiness;
        public UserController(IUserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }

        [HttpPost]
        [Route("User_Registration")]
        public IActionResult Registration(UserRegistrationModel model)
        {
            var result = userBusiness.UserRegistration(model);
            if(result != null)
            {
                return Ok(new { success = true, message = "User Registration Successfull", data = result });
            }
            else
            {
                return BadRequest(new { success = false, message = "User Registration Failed", data = result });
            }
        }



    }
}
