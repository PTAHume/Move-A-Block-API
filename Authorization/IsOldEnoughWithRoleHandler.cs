namespace Move_A_Block_API.Authorization
{
    using Microsoft.AspNetCore.Authorization;
    using System.Globalization;
    using System.Security.Claims;

    public class IsOldEnoughWithRoleHandler : AuthorizationHandler<IsOldEnoughWithRoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsOldEnoughWithRoleRequirement requirement)
        {
            string bDay = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.DateOfBirth)?.Value ?? DateTime.Now.ToString(CultureInfo.CurrentCulture);
            DateTime bDayObj = Convert.ToDateTime(bDay);

            DateTime now = DateTime.Today;
            int age = DateTime.Today.Year - bDayObj.Year;
            if (now < bDayObj.AddYears(age))
                age--;

            if (requirement.MinAge <= age && context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
