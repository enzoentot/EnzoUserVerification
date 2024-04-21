using BusinessLayer;

namespace ProgramUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string Password = Console.ReadLine();

            VerificationID UserService = new VerificationID();
            bool result = UserService.VerifyUserName(UserName);

            VerificationID PasswordService = new VerificationID();
            bool result1 = PasswordService.VerifyPassword(Password);

            if (result1 && result)
            {
                Console.WriteLine("WELCOME!");
            }
            else
            {
                Console.WriteLine("Failed, try again");
            }

        }
    }
}
