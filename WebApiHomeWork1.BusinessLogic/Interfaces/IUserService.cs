using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.BusinessLogic.Interfaces;

public interface IUserService
{
    Task<List<User?>> GetAll();
    
    Task<User?> Get(string email, string password);
    
    void Create(User? user);
    
    void Edit(User user);
}