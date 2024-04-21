using EnzoUserVerification;
namespace DataLayer
{
    public class UserDataServices
    {
        List<ModelService> dummyAcc = new List<ModelService>();

        public UserDataServices()
        {
            CreateDummyAccount();
        }

        private void CreateDummyAccount()
        {
            ModelService dummy1 = new ModelService
            {
                UserName = "enzo",
                Password = "mendoza"
            };
            ModelService dummy2 = new ModelService
            {
                UserName = "charles",
                Password = "Garcia"
            };
            ModelService dummy3 = new ModelService
            {
                UserName = "jojo",
                Password = "gogo"
            };
            ModelService dummy4 = new ModelService
            {
                UserName = "aji",
                Password = "nomoto"
            };

            dummyAcc.Add(dummy1);
            dummyAcc.Add(dummy2);
            dummyAcc.Add(dummy3);
            dummyAcc.Add(dummy4);

        }

        public ModelService GetAccount(string Username)
        {
            ModelService FoundUser = new ModelService();

            foreach (var dummy in dummyAcc)
            {
                if (Username == dummy.UserName)
                {
                    FoundUser = dummy;
                }

            }
            return FoundUser;
        }
        public ModelService GetPassword(string Password)
        {
            ModelService FoundPassword = new ModelService();

            foreach (var dummy in dummyAcc)
            {
                if (Password == dummy.Password)
                {
                    FoundPassword = dummy;
                }

            }
            return FoundPassword;
        }
    }
}

