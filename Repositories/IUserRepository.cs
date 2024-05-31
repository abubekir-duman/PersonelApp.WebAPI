using PersonelApp.WebAPI.Models;

namespace PersonelApp.WebAPI.Repositories;

public interface IUserRepository
{
    bool Create(User user);
    bool ISUserNameExists(string userName);
    User? GetByUserNameAndPassword(string userName, string password);
}
