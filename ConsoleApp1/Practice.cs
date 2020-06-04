using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Practice
    {

        public IWebHostBuilder ConfigureServices(Action<IServiceCollection> configureServices)
        {
            if(configureServices == null)
            {
                throw new ArgumentNullException(nameof(configureServices));
            }

            return ConfigureServices((_, services) => configureServices(services));
        }

        public IWebHostBuilder ConfigureServices(
            Action<WebHostBuilderContext, IServiceCollection> configureServices)
        {
            //if (configureServices == null)
            //    throw new ArgumentNullException(nameof(configureServices));
            //this._configureServicesDelegates.Add(configureServices);
            return (IWebHostBuilder)this;
        }

    }
}
