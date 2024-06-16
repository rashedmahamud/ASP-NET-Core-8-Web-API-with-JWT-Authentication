using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace jwt_auth.Helper
{
    public  class JwtAuthorizationFilter:IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = (string)context.HttpContext.Items["userName"];

            if (user == null)
            {
                // Unauthorized
                context.Result = new UnauthorizedResult();
            }
            // You can add more fine-grained authorization logic here if needed
        }
    }
}
