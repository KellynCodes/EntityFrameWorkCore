using EfCore.BLL.CrudOperation.Interfaces;
using EfCore.BLL.Services;
using EfCore.DAL.EfCoreSetup;
using Microsoft.EntityFrameworkCore;

namespace EfCore.BLL.CrudOperation.Implementation
{
    public class Delete : IDelete
    {
        ReliconDbFactory reliconDbFactory = new ReliconDbFactory();
        public async Task Del(int id)
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var DelUser = await DbContext.Users.SingleOrDefaultAsync(user => user.Id == id);

            string Message = "Delete operation was successfull.";
            if (DelUser != null)
            {
                await DbContextSave.DeleteAsync(DelUser, Message);
            }
            else
            {
                Console.WriteLine("User does'nt exist.");
            }
        }
    }
}
