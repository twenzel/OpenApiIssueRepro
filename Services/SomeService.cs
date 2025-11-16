using IdentityExpress.Identity;

namespace OpenApiIssueRepro.Services
{
    public class SomeService
    {
        public IdentityServerUserManager<IdentityExpressUser> UserManager { get; }

        public SomeService(IdentityServerUserManager<IdentityExpressUser> userManager)
        {
            UserManager = userManager;
        }
    }
}
