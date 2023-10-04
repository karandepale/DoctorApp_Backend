using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoLayer.Interfaces
{
    public interface IUserRepo
    {
        public UserRegistrationModel UserRegistration(UserRegistrationModel model);
    }
}
