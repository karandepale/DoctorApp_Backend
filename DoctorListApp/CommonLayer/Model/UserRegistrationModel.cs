using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Model
{
    public class UserRegistrationModel
    {
        public int RoleID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime Update_At { get; set; }
    }
}
