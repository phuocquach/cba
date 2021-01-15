using CBA.Features.Services;
using System;
using System.Threading.Tasks;

namespace CBA
{
    public interface ICommand
    {
        Task Process(int accountId);
    }

    public class DepositCommand : ICommand
    {
        private readonly IBankingServices _bankingServices;
        public DepositCommand(IBankingServices bankingServices)
        {
            _bankingServices = bankingServices;
        }
        public async Task Process(int accountId)
        {
            Console.WriteLine("How much do you want to deposit ?");
            Console.WriteLine("");
            double depositNumber;
            do
            {
                var inputDeposit = Console.ReadLine();
                if (double.TryParse(inputDeposit, out depositNumber))
                {
                    break;
                }

            } while (true);

            _bankingServices.Deposit(accountId, depositNumber);

            Console.WriteLine($"Your new balance is: {_bankingServices.GetAccount(accountId).Balance}");
        }
    }

    public class WithdrawCommand : ICommand
    {
        private readonly IBankingServices _bankingServices;
        public WithdrawCommand(IBankingServices bankingServices)
        {
            _bankingServices = bankingServices;
        }
        public async Task Process(int accountId)
        {
            Console.WriteLine("How much do you want to Withdraw ?");
            double depositNumber;
            do
            {
                var inputDeposit = Console.ReadLine();
                if (double.TryParse(inputDeposit, out depositNumber))
                {
                    break;
                }

            } while(true) ;

            _bankingServices.Withdraw(accountId, depositNumber);

            Console.WriteLine($"Your new balance is: {_bankingServices.GetAccount(accountId).Balance}");
        }
    }

    public class ExitCommand : ICommand
    {
        public async Task Process(int AccountId)
        {
            Console.WriteLine("Goodbye");
        }
    }
}