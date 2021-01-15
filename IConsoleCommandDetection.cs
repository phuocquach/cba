using System;

namespace CBA
{
    public interface IConsoleCommandDetection
    {
        ICommand DetectCommand(ConsoleKeyInfo input); 
    }
}
