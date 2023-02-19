using EfCore.DAL.Models;

namespace EfCore.BLL.Services
{
    public class CollectUserInfo
    {
        public static User UserInfo()
        {
            string name = Name();
            string email = Email();
            string password = Password();
            string userName = UserName();
            string phone = Phone();
            string address = Address();

            var newUser = new User
            {
                Name = name,
                Email = email,
                Password = password,
                UserName = userName,
                Phone = phone,
                Address = address,
                IsActive = true,
            };

            return newUser;
        }





        private static string Name()
        {
        EnterName: Console.WriteLine("Enter you name.");
            string name = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Input was empty. please try again.");
                goto EnterName;
            }
            return name;
        }

        private static string UserName()
        {
        EnterUserName: Console.WriteLine("Enter you Username.");
            string UserName = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(UserName))
            {
                Console.WriteLine("Input was empty. please try again.");
                goto EnterUserName;
            }
            return UserName;
        }

        private static string Email()
        {
        EnterEmail: Console.WriteLine("Enter you email.");
            string email = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Input was empty. please try again.");
                goto EnterEmail;
            }
            if (!email.Contains('@'))
            {
                Console.WriteLine("Email must contain @ symbol.");
                goto EnterEmail;
            }
            return email;
        } 
        
        private static string Password()
        {
        EnterPassword: Console.WriteLine("Enter you email.");
            string password = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Input was empty. please try again.");
                goto EnterPassword;
            } 
            if (password.Length < 6)
            {
                Console.WriteLine("Password cannot be less than 6 characters.");
                goto EnterPassword;
            }
            return password;
        }

        private static string Phone()
        {
        EnterPhone: Console.WriteLine("Enter your phone number.");
            string Phone = Console.ReadLine() ?? string.Empty;
            if (Phone.Length > 11)
            {
                Console.WriteLine("Phone number cannot be greater than 11 digits. Please do try again.");
                goto EnterPhone;
            }
            return Phone;
        }

        private static string Address()
        {
        EnterEmail: Console.WriteLine("Enter you Address.");
            string address = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Input was empty. please try again.");
                goto EnterEmail;
            }
            return address;
        }

    }
}
