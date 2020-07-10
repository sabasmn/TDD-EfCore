using System;
using SAM.HealthCare.Services.Services;

namespace SAM.HealthCare.Tests
{
    public class BaseTest
    {
        private IServiceProvider ServiceProvider { get; set; }
        public T GetAppService<T>() where T : IApplicationService
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }
        public BaseTest()
        {
            ServiceProvider = DependencyInjector.GetServiceProvider();
        }
    }
}