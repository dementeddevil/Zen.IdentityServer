using System.Security.Claims;
using IdentityServer8.Models;
using IdentityServer8.Test;

namespace IdentityServerHost.Extensions
{
    public class HostProfileService : TestUserProfileService
    {
        public HostProfileService(TestUserStore users, ILogger<TestUserProfileService> logger) : base(users, logger)
        {
        }

        public override async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            await base.GetProfileDataAsync(context);

            var transaction = context.RequestedResources.ParsedScopes.FirstOrDefault(x => x.ParsedName == "transaction");
            if (transaction?.ParsedParameter != null)
            {
                context.IssuedClaims.Add(new Claim("transaction_id", transaction.ParsedParameter));
            }
        }
    }
}