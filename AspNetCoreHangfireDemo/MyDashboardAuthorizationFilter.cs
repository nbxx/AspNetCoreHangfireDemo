using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire.Annotations;
using Hangfire.Dashboard;

namespace AspNetCoreHangfireDemo
{
    public class MyDashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize([NotNull] DashboardContext context)
        {
            var clientIp = context.GetHttpContext().Request?.HttpContext?.Connection?.RemoteIpAddress?.MapToIPv4()?.ToString();

            return true;
        }
    }
}
