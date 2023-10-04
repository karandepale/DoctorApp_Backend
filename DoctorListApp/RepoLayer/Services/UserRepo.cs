using CommonLayer.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RepoLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RepoLayer.Services
{
    public class UserRepo : IUserRepo
    {
        private readonly IConfiguration configuration;
        public UserRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public UserRegistrationModel UserRegistration(UserRegistrationModel model)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.configuration.GetConnectionString("DoctorList")))
                {
                    SqlCommand cmd = new SqlCommand("SP_Users_Registration", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoleID", model.RoleID);
                    cmd.Parameters.AddWithValue("@FullName", model.FullName);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    cmd.Parameters.AddWithValue("@Contact", model.Contact);
                    cmd.Parameters.AddWithValue("@Create_At", model.Create_At);
                    cmd.Parameters.AddWithValue("@Update_At", model.Update_At);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    return model;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }













    }
}
