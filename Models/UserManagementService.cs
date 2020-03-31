using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CatBoardApi.Models;
// using CatBoardApi.Models.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CatBoardApi.Models
{
  public class UserManagementService : IUserManagementService
  {

    private readonly SignInManager<User> _signInManager;

    public UserManagementService(SignInManager<User> signInManager)
    {
      _signInManager = signInManager;
    }

    public async Task<bool> IsValidUser(string userName, string password)
    {

      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(userName, password, isPersistent: false, lockoutOnFailure: false);

      if(result.Succeeded)
      {
        return true;
      }
      else 
      {
        return false;
      }

      // var thisUser = _db.Users.FirstOrDefault(user => user.Name == userName);
      // if (thisUser.Password == password)
      // {
      //   return true;
      // }
      // return true;
    }
  }
}