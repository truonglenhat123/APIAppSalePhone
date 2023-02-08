using Microsoft.AspNetCore.Identity;

namespace APIAppSalePhone.Repository
{
    public interface IAccountRepository
    {
        public bool SignUp(RegisterModel model);
        public string SignIn(LoginModel model);

    }
}
