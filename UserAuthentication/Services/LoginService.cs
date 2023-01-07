using UserAuthentication.Models;

namespace UserAuthentication.Services
{
    public class LoginService
    {
        private static List<LoginModel> list = new List<LoginModel>();

        internal static List<LoginModel> GetNamePassword()
        {
            return list;
            
        }

        internal static void SetNamePassword(LoginModel model)
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
