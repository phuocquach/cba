using System.Threading.Tasks;

namespace CBA.Features.Services
{
    public interface IBankingServices
    {
        Task Deposit(int AccountId, double number);
        Task Withdraw(int AccountId, double number);
        public AccountDto GetAccount(int AccountId);
    }
}
