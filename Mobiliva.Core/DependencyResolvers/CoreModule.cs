using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Mobiliva.Core.CrossCuttingConcern.Caching;
using Mobiliva.Core.CrossCuttingConcern.Caching.Microsoft;
using Mobiliva.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
