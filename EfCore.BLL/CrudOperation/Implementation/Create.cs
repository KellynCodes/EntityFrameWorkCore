using EfCore.BLL.CrudOperation.Interfaces;
using EfCore.DAL.EfCoreSetup;
using EfCore.DAL.Models;

namespace EfCore.BLL.CrudOperation.Implementation
{
    public class Create : ICreate
    {
        private readonly ReliconDbFactory reliconDbFactory = new();

        public async Task CreateUserAsync()
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);


            var NewUser = new User
            {
                Name = "John Brendan",
                UserName = "Brendanny",
                Email = "brendanny@gmail.com",
                Password = "12345",
                Phone = "08144217359",
                Address = "Igbo-Etiti local Govt. Enugu state, Nigeria",
                IsActive = true,
                CreatedAt = DateTime.Now,

                Tasks = new List<Tasks>()
                {

                   new Tasks()
                   {
                        Name = "Hiking",
                         Description = "Blala Blue",
                         Tags = new List<Tag>()
                         {
                             new Tag()
                             {
                                 Name = "OutDoor",
                                 Description = "We are going to play football tomorrow by 2.00pm"
                             },

                             new Tag()
                             {
                                 Name = "Activity",
                                 Description = "Run arround the field before starting play.",
                             }
                         }
                     },

                     new Tasks
                     {
                         Name = "Eating",
                         Description = "BreakFast: Tea and bread, Launch: Pap and Beans, Dinner: Pap and Beans.",

                         Tags = new List<Tag>()
                         {
                             new Tag()
                             {
                                 Name = "Self Care",
                                 Description = "Putting myself first"
                             }
                        }
                     }
                 }
            };

            DbContext.Add(NewUser);
            int RowsAffected = await DbContext.SaveChangesAsync();
            string Message = (RowsAffected > 0) ? "User created successfully." : "User creation was not successfull.";
            Console.WriteLine(Message);
        }

        public async Task<IEnumerable<User>> CreateUserAsync(User user)
        {
            var DbContext = reliconDbFactory.CreateDbContext(null);

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

            DbContext.Add(RegisteredUser);
            newUser.Add(RegisteredUser);
           int RowsAffected = await DbContext.SaveChangesAsync();
            string Message = (RowsAffected > 0) ? "User created successfully." : "User creation was not successfull.";
            Console.WriteLine(Message);
            return newUser;
        }
    }
}
