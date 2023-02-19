using EfCore.BLL.CrudOperation.Interfaces;
using EfCore.DAL.EfCoreSetup;
using EfCore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.BLL.CrudOperation.Implementation
{
    public class Update : IUpdate
    {
        ReliconDbFactory reliconDbFactory = new ReliconDbFactory();
        public async Task Run(int id, User user)
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var UserToUpdate = await DbContext.Users.SingleOrDefaultAsync(user => user.Id == id);
            if (UserToUpdate != null)
            {
                UserToUpdate.Name = user.Name;
                UserToUpdate.Email = user.Email;
                UserToUpdate.UserName = user.UserName;
                UserToUpdate.Password = user.Password;
                UserToUpdate.Phone = user.Phone;
                UserToUpdate.Address = user.Address;
                UserToUpdate.IsActive = user.IsActive;
                UserToUpdate.CreatedAt = user.CreatedAt;
            }

            int RowsAffected = await DbContext.SaveChangesAsync();
            string Message = (RowsAffected > 0) ? "Update was successfull." : "Operation was not successfull.";
            Console.WriteLine(Message);
        }
    }
}
