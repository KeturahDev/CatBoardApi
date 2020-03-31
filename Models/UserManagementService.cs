using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CatBoardApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CatBoardApi.Models
{
  public class UserManagementService : IUserManagementService
  {

    // private readonly SignInManager<User> _signInManager;


    public bool IsValidUser(string userName, string password)
    {
      return true;
    }
  }
}