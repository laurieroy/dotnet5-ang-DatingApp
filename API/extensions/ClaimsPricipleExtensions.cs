using System.Security.Claims;

namespace API.extensions
{
    public static class ClaimsPricipleExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}