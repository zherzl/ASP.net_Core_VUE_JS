using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.ServiceProviderExtensions
{
    public static class ServiceProviderServiceExtensions
    {
        public static T GetService<T>(this IServiceProvider provider)
        {
            return (T)provider.GetService(typeof(T));
        }


    }
}
