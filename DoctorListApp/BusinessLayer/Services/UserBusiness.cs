using BusinessLayer.Interfaces;
using CommonLayer.Model;
using RepoLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepo userRepo;
        public UserBusiness(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }

        public UserRegistrationModel UserRegistration(UserRegistrationModel model)
        {
            try
            {
               return userRepo.UserRegistration(model);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }




    }
}
