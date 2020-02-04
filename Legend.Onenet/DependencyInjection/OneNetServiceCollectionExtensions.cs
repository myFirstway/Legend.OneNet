#if NETSTANDARD20
using Legend.Onenet.Services;
using Legend.Onenet.Services.Command;
using Legend.Onenet.Services.Device;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Legend.Onenet.DependencyInjection
{
    public static class OneNetServiceCollectionExtensions
    {
        public static IServiceCollection AddOneNetClient(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddHttpClient("onenetClient");
            services.AddSingleton<IOnenetClient, OnenetClient>();
            services.AddSingleton<ITokenService, ApiKeyTokenService>();
            services.AddSingleton<ICommandServices, CommandServices>();
            services.AddSingleton<IDeviceServices, DeviceServices>();
            services.AddSingleton<IApikeyManageServices, ApikeyManageServices>();
            services.AddSingleton<IDataManageServices, DataManageServices>();
            services.AddSingleton<ITopicServices, TopicServices>();
            services.AddSingleton<ITriggerServices, TriggerServices>();
            return services;
        }
    }
}
#endif