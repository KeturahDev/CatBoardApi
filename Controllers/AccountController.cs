using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CatBoardApi.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
// using CatBoardApi.ViewModels;

namespace CatBoardApi.Controllers
{
  [Route("api/[controller]")]
  public class AccountController : ControllerBase
  {
    private readonly CatBoardApiContext _db;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public AccountController (UserManager<User> userManager, SignInManager<User> signInManager, CatBoardApiContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   return View();
    // }

    // public IActionResult Register()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public async Task<bool> Register ([FromBody] User model)
    // {
    //   var thisUser = new User { UserName = model.Email};
    //   IdentityResult result = await _userManager.CreateAsync(model.Email, model.Password);
    //   if (result.Succeeded)
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }

    // public ActionResult Login()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public async Task<ActionResult> Login(LoginViewModel model)
    // {
    //   Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
    //   if(result.Succeeded)
    //   {
    //     return RedirectToAction("Index");
    //   }
    //   else
    //   {
    //     return View();
    //   }
    // }

    // [HttpPost]
    // public async Task<ActionResult> LogOff()
    // {
    //   await _signInManager.SignOutAsync();
    //   return RedirectToAction("Index");
    // }
  }
}