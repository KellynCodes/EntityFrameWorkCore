using EfCore.DAL.Models;

namespace EfCore.BLL.CrudOperation.Interfaces
{
    public interface IRead
    {
        Task AllUsers();
        Task User(string email, string password);
        Task AllTasks();
        Task Task(int userId);
        Task AllTags();
        Task Tag(int userId);
    }
}
