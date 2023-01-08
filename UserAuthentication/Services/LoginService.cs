using UserAuthentication.Models;

namespace UserAuthentication.Services
{
    public static class LoginService
    {
        private static List<LoginModel> list = new List<LoginModel>();

        public static List<LoginModel> GetNamePassword()
        {
            return list;
            
        }


        public static void SetNamePassword(LoginModel model)
        {
            foreach(LoginModel login in list) 
            {
                if(model != login)
                {
                    list.Add(model);
                }
                else
                {
                    return;
                }
            }
           
            
        }
    }
}
