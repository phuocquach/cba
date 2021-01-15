using Microsoft.Extensions.DependencyInjection;
using System;

namespace CBA
{
    public class ConsoleCommandDetection : IConsoleCommandDetection
    {
        private readonly IServiceProvider _serviceProvider;
        public ConsoleCommandDetection(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public ICommand DetectCommand(ConsoleKeyInfo input)
        {
            return input.Key switch {
                ConsoleKey.D1 => _serviceProvider.GetRequiredService<Command>(),
                ConsoleKey.D2 => _serviceProvider.GetRequiredService<WithdrawCommand>(),
                ConsoleKey.D0 => _serviceProvider.GetRequiredService<ExitCommand>(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
