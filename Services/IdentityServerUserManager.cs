using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace OpenApiIssueRepro.Services
{
    /// <summary>
    /// User manager
    /// </summary>
    /// <typeparam name="TUser"></typeparam>
    public partial class IdentityServerUserManager<TUser> : UserManager<TUser> where TUser : TestUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager{TUser}"/> class.
        /// </summary>
        /// <param name="store"></param>
        /// <param name="optionsAccessor"></param>
        /// <param name="passwordHasher"></param>
        /// <param name="userValidators"></param>
        /// <param name="passwordValidators"></param>
        /// <param name="keyNormalizer"></param>
        /// <param name="errors"></param>
        /// <param name="services"></param>
        /// <param name="logger"></param>
        public IdentityServerUserManager(
        IUserStore<TUser> store,
        IOptions<IdentityOptions> optionsAccessor,
        IPasswordHasher<TUser> passwordHasher,
        IEnumerable<IUserValidator<TUser>> userValidators,
        IEnumerable<IPasswordValidator<TUser>> passwordValidators,
        ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors,
        IServiceProvider services,
        ILogger<IdentityServerUserManager<TUser>> logger
        ) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {

        }

        /// <summary>
        /// Searches for users including deleted
        /// </summary>
        public void EnableIncludeDeletedUsers()
        {

        }

        /// <summary>
        /// Searches for users including deleted
        /// </summary>
        public void DisableIncludeDeletedUsers()
        {

        }
    }
}

public class TestUser
{
    public string Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}