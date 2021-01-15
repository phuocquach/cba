using System;
using System.Threading.Tasks;

namespace CBA
{
    public class ConsoleApplication: IApplication
    {
        private readonly IConsoleCommandDetection _commandDetection;
        public ConsoleApplication(IConsoleCommandDetection commandDetection)
        {
            _commandDetection = commandDetection;
        }
        public async Task Run()
        {
            var isExit = false;
            
            Console.WriteLine("Hello, please input your accountId:");
            var accountId = Console.ReadLine();
            do
            {
                Console.WriteLine("Please input your command:");

                var key = Console.ReadKey();
                var command = _commandDetection.DetectCommand(key);
                await command.Process(int.Parse(accountId));

                if (command is ExitCommand)
                {
                    isExit = true;
                }

            } while (!isExit);
        }
    }
}
