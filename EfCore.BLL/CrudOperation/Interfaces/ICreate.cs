using EfCore.DAL.Models;
namespace EfCore.BLL.CrudOperation.Interfaces
{
    public interface ICreate
    {
        Task CreateUserAsync(User user, Tasks tasks, Tag tag);
        Task CreateTaskAsync(Tasks tasks, Tag tag);
        Task<IEnumerable<User>> CreateUserAsync(User user);
    }
}
