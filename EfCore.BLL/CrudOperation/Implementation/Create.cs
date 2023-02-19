using EfCore.BLL.CrudOperation.Interfaces;
using EfCore.DAL.Models;
using EfCore.BLL.Services;

namespace EfCore.BLL.CrudOperation.Implementation
{
    public class Create : ICreate
    {

        public async Task CreateUserAsync(User user, Tasks tasks, Tag tag)
        {
            var NewUser = new User
            {
                Name = user.Name,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                Phone = user.Password,
                Address = user.Address,
                IsActive = user.IsActive,
                CreatedAt = user.CreatedAt,

                Tasks = new List<Tasks>()
                {

                   new Tasks()
                   {
                        Name = tasks.Name,
                         Description = tasks.Description,
                         Tags = new List<Tag>()
                         {
                             new Tag()
                             {
                                 Name = tag.Name,
                                 Description = tag.Description
                             },
                         }
                     },

                 }
            };
            string Message = "User, Tasks and tag created successfully";
          await DbContextSave.AddChangesAsync(NewUser, Message);
        }
            
        public async Task CreateTaskAsync(Tasks tasks, Tag tag)
        {
            var newTask = new Tasks
            {
                        Name = tasks.Name,
                         Description = tasks.Description,
                         Tags = new List<Tag>()
                         {
                             new Tag()
                             {
                                 Name = tag.Name,
                                 Description = tag.Description
                             },
                         }
            };

          
            string Message = "Task created successfully.";
            await DbContextSave.AddChangesAsync(newTask, Message);
        }

        public async Task<IEnumerable<User>> CreateUserAsync(User user)
        {
            IList<User> newUser = new List<User>();
            User RegisteredUser = new User
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Phone = user.Phone,
                UserName = user.UserName,
                Address = user.Address,
                CreatedAt = user.CreatedAt,
                IsActive = user.IsActive
            };

          
            
            string Message = "User created successfully";
            await DbContextSave.AddChangesAsync(RegisteredUser, Message);
            newUser.Add(RegisteredUser);
            return newUser;
        }
    }
}
