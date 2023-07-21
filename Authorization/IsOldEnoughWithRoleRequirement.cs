namespace Move_A_Block_API.Authorization
{
    using Microsoft.AspNetCore.Authorization;

    public class IsOldEnoughWithRoleRequirement : IAuthorizationRequirement
    {
        public IsOldEnoughWithRoleRequirement(int minAge)
        {
            MinAge = minAge;
        }

        public int MinAge { get; set; }
    }
}
