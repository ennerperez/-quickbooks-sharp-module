using System;
using QuickBooks.Interfaces;
using QuickBooks.Services;
using Microsoft.Extensions.DependencyInjection;

namespace QuickBooks
{
    public static class Extensions
    {
        public static IServiceCollection AddQuickBooksServices(this IServiceCollection services, Action<Options> configureOptions = null)
        {
            services.AddHttpClient<QuickBooksService>("QuickBooksService");
            services.AddSingleton<Factory>().Configure(configureOptions);

            services.AddSingleton<IBookService, BookService>().Configure(configureOptions);
            services.AddSingleton<ICampaignService, CampaignService>().Configure(configureOptions);
            services.AddSingleton<ISubscriptionService, SubscriptionService>().Configure(configureOptions);

            services.AddSingleton<Wrapper>();

            return services;
        }
    }
}