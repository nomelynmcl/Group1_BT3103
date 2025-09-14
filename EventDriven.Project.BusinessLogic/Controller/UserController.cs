using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;


namespace EventDriven.Project.Businesslogic.Controller
{
    public class UserController
    {
        private UserRepository userRepo;
        

        public UserController()
        {
            userRepo = new UserRepository();
        }

        public List<UserModel> GetUserList()
        {
            return new List<UserModel> { new UserModel() };
        }

        public UserModel ValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username or Password cannot be empty.");
            }

            return userRepo.ValidateUser(username, password);
        }
    }
}
