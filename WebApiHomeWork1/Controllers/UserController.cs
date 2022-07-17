using Microsoft.AspNetCore.Mvc;
using WebApiHomeWork1.BusinessLogic.Services;
using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.Controllers;

[ApiController]
[Route("api/[user-controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    
    public UserController(UserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    public Task<List<User?>> GetAllUser()
    {
        return _userService.GetAll();
    }
    
    [HttpGet]
    public Task<User?> GetUser(string email, string password)
    {
        if (ModelState.IsValid)
        {
            return _userService.Get(email, password);
        }

        return null;
    }
    
    [HttpPost]
    public void CreateNewUser(User user)
    {
        if (ModelState.IsValid)
        {
            _userService.Create(user);
        }
    }
    
    [HttpPut]
    public void EditUser(User user)
    {
        if (ModelState.IsValid)
        {
            _userService.Edit(user);
        }
    }
}