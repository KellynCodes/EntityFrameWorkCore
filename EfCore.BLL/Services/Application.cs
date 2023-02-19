using EfCore.BLL.CrudOperation.Implementation;
using EfCore.BLL.CrudOperation.Interfaces;
using EfCore.BLL.Services;
using EfCore.DAL.Enums;
using EfCore.DAL.Models;

namespace EfCore.BLL.Utility
{
    public class Application
    {
        public async static Task Run()
        {
            ICreate create = new Create();

         Start:   Console.WriteLine("Choose from the options.");
            Console.WriteLine("1.Create new account.\n2.View Users \n3.Delere User\n4. Update account.");
            if (int.TryParse(Console.ReadLine(), out int Choice))
            {
                switch (Choice)
                {
                    case (int)SwitchCase.CaseOne:
                       await create.CreateUserAsync(CollectUserInfo.UserInfo());
                       await create.CreateUserAsync();
                        break;
                    default: Console.WriteLine("Entered value is not in the options. Try again.");
                        goto Start;
                }
            }

        }
    }
}
