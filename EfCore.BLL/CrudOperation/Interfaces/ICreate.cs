using EfCore.DAL.Models;
namespace EfCore.BLL.CrudOperation.Interfaces
{
    public interface ICreate
    {
        Task CreateUserAsync();
        Task<IEnumerable<User>> CreateUserAsync(User user);
    }
}
