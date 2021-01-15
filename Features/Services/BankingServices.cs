using CBA.Features.Entity;
using CBA.Features.Mapper;

namespace CBA.Features.Services
{
    public class BankingServices: IBankingServices
    {
        private readonly Bank _bank;
        private readonly IMapper _mapper;
        public BankingServices(Bank bank, IMapper mapper)
        {
            _bank = bank;
            _mapper = mapper;
        }

        public void Deposit(int AccountId, double number)
        {
            _bank.GetAccount(AccountId).Deposit(number);
        }

        public AccountDto GetAccount(int AccountId)
        {
            return _mapper.Map(_bank.GetAccount(AccountId));
        }

        public void Withdraw(int AccountId, double number)
        {
            _bank.GetAccount(AccountId).Withdraw(number);
        }
    }
}
