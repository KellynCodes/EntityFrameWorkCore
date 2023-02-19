using EfCore.DAL.Models;

namespace EfCore.BLL.CrudOperation.Interfaces
{
    public interface IUpdate
    {
        Task Run(int id, User user);
    }
}
