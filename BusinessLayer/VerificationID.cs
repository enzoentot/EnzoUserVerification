using DataLayer;
namespace BusinessLayer
    
{
    public class VerificationID
    {
        public bool VerifyUserName(string userName)
        {
            UserDataServices UserService = new UserDataServices();
            var result = UserService.GetAccount(UserName);

            return result.UserName != null ? true : false;  
        }
        public bool VerifyPassword(string Password)
        {
            UserDataServices PasswordService = new UserDataServices();
            var result = PasswordService.GetPassword(Password);

            return result.Password != null ? true : false;

        }
    }
}
