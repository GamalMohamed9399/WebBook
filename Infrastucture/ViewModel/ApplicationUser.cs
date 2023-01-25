using Microsoft.AspNetCore.Identity;

namespace Infrastucture.ViewModel
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string ImageUser { get; set; }
        public string ActiveUser { get; set; }
    }
}
