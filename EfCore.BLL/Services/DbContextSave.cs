using EfCore.DAL.EfCoreSetup;
using EfCore.DAL.Models;

namespace EfCore.BLL.Services
{
    public class DbContextSave
    {
        public static async Task AddChangesAsync(object obj, string message)
        {

            ReliconDbFactory reliconDbFactory = new();
            var DbContext = reliconDbFactory.CreateDbContext(null);

            DbContext.Add(obj);
            int RowsAffected = await DbContext.SaveChangesAsync();
            string Message = (RowsAffected > 0) ? message : "Operation was not successfull.";
            Console.WriteLine(Message);
        }

        public static async Task DeleteAsync(User obj, string message)
        {
            ReliconDbFactory reliconDbFactory = new();
            var DbContext = reliconDbFactory.CreateDbContext(null);

            DbContext.Users.Remove(obj);
            int RowsAffected = await DbContext.SaveChangesAsync();
            string Message = (RowsAffected > 0) ? message : "Operation was not successfull.";
            Console.WriteLine(Message);
        }
    }
}
