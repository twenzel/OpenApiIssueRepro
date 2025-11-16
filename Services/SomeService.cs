namespace OpenApiIssueRepro.Services
{
    public class SomeService
    {
        public IdentityServerUserManager<TestUser> UserManager { get; }

        public SomeService(IdentityServerUserManager<TestUser> userManager)
        {
            UserManager = userManager;
        }
    }
}
