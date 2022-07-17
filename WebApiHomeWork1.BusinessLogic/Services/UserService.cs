using Microsoft.EntityFrameworkCore;
using WebApiHomeWork1.BusinessLogic.Context;
using WebApiHomeWork1.BusinessLogic.Interfaces;
using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.BusinessLogic.Services;

public class UserService : IUserService
{
    private readonly UserContext _db;

    public UserService(UserContext db)
    {
        _db = db;
    }
    
    public async Task<List<User?>> GetAll()
    {
        return await _db.Users.ToListAsync();
    }

    public async Task<User?> Get(string email, string password)
    {
        User? user = await _db.Users.FirstOrDefaultAsync(
            x => x != null && x.Email == email && x.Password == password);
        
        return user;
    }

    public async void Create(User? user)
    {
        _db.Users.Add(user);
        await _db.SaveChangesAsync();
    }

    public async void Edit(User user)
    {
        if (!_db.Users.Any(x => x != null && x.Id ==user.Id))
        {
            return;
        }
 
        _db.Update(user);
        await _db.SaveChangesAsync();
    }
}