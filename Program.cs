using CBA.Features.Entity;
using CBA.Features.Mapper;
using CBA.Features.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CBA
{
    class Program
    {
        private static ServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            try
            {
                scope.ServiceProvider.GetRequiredService<IApplication>().Run();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            DisposeServices();
        } 

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IConsoleCommandDetection, ConsoleCommandDetection>();
            services.AddSingleton<IApplication, ConsoleApplication>();
            services.AddSingleton<IBankingServices, BankingServices>();
            services.AddSingleton<Bank>();
            services.AddSingleton<IMapper, Mapper>();
            services.AddTransient<DepositCommand>();
            services.AddTransient<ExitCommand>();
            services.AddTransient<WithdrawCommand>();
            _serviceProvider = services.BuildServiceProvider(true);
        }

        static private void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
