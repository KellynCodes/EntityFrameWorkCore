using EfCore.BLL.CrudOperation.Interfaces;
using EfCore.DAL.EfCoreSetup;
using Microsoft.EntityFrameworkCore;

namespace EfCore.BLL.CrudOperation.Implementation
{
    public class Read : IRead
    {
        ReliconDbFactory reliconDbFactory = new();

        public async Task AllUsers()
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var userInfo = DbContext.Users;
           await foreach(var ViewUser in userInfo)
            {
                Console.WriteLine($"Name: {ViewUser.Name} UserName: {ViewUser.UserName} Email: {ViewUser.Email} Address: {ViewUser.Address} CreatedAt: {ViewUser.CreatedAt}");
                Console.WriteLine();
            }
        }

        public async Task User(string email, string password)
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var userInfo = await DbContext.Users.FirstOrDefaultAsync(user => user.Email == email && user.Password == password);
                Console.WriteLine($"{userInfo?.Name} {userInfo?.UserName} {userInfo?.Email} {userInfo?.Address} {userInfo?.CreatedAt}");
        }
        
        public async Task ActiveUsers(bool isActive)
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var userInfo = await DbContext.Users.FirstOrDefaultAsync(user => user.IsActive == isActive);
                Console.WriteLine($"{userInfo?.Name} {userInfo?.UserName} {userInfo?.Email} {userInfo?.Address} {userInfo?.CreatedAt}");
        }

        public async Task AllTasks()
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var TasksInfo = DbContext.Tasks;
            await foreach (var Task in TasksInfo)
            {
                Console.WriteLine($"Name: {Task.Name} Description: {Task.Description}");
                Console.WriteLine();
            }
        }
        
        public async Task Task(int userId)
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var TasksInfo = await DbContext.Tasks.FirstOrDefaultAsync(Task => Task.UserId == userId);
                Console.WriteLine($"Name: {TasksInfo?.Name} Description: {TasksInfo?.Description}");
                Console.WriteLine();
        }

        public async Task AllTags()
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var TagInfo = DbContext.Tags;
            await foreach (var Tag in TagInfo)
            {
                Console.WriteLine($"Name: {Tag.Name} Description: {Tag.Description}");
                Console.WriteLine();
            }
        }

        public async Task Tag(int Id)
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);
            var TagInfo = await DbContext.Tags.FirstOrDefaultAsync(Tag => Tag.Id == Id);
                Console.WriteLine($"Name: {TagInfo?.Name} Description: {TagInfo?.Description}");
                Console.WriteLine();
        }
    }
}