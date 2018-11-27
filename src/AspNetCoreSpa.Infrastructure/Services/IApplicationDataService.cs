using Microsoft.AspNetCore.Http;

namespace MyCommunity.Infrastructure.Services
{
    public interface IApplicationDataService
    {
        object GetApplicationData(HttpContext context, string stsAuthority);
    }
}