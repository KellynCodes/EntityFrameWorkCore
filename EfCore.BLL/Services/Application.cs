using EfCore.BLL.CrudOperation.Implementation;
using EfCore.BLL.CrudOperation.Interfaces;
using EfCore.BLL.Services;
using EfCore.DAL.Enums;

namespace EfCore.BLL.Utility
{
    public class Application
    {
        public async static Task Run()
        {
            ICreate create = new Create();
            IRead read = new Read();
            IUpdate update = new Update();
            IDelete delete = new Delete();

            await read.User("kellyncodes@gmail.com", "1234567");
            await read.AllTasks();
            await read.Task(6);
            await read.AllTags();
            await read.Tag(1);

         Start:   Console.WriteLine("Choose from the options.");
            Console.WriteLine("1.Create new account.\n2.View Users \n3.Delete User\n4. Update account.");
            if (int.TryParse(Console.ReadLine(), out int Choice))
            {
                switch (Choice)
                {
                    case (int)SwitchCase.CaseOne:
                       await create.CreateUserAsync(CollectUserInfo.UserInfo());
                        break;
                    case (int)SwitchCase.CaseTwo:
                        await read.AllUsers();
                        break;
                    case (int)SwitchCase.CaseThree:
                        await delete.Del(6);
                        break;
                    case (int)SwitchCase.CaseFour:
                        await update.Run(9, CollectUserInfo.UserInfo());
                        break;
                    default: Console.WriteLine("Entered value is not in the options. Try again.");
                        goto Start;
                }
            }

        }
    }
}
