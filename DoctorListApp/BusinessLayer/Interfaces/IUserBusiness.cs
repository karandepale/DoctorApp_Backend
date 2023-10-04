using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IUserBusiness
    {
        public UserRegistrationModel UserRegistration(UserRegistrationModel model);
    }
}
