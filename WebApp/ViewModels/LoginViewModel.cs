using Microsoft.Build.Framework;

namespace WebApp.ViewModels
{
    public class LoginViewModel
    {

        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public bool RememberMe { get; set; } = false;
    }
}
