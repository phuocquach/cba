using System;

namespace CBA.Features.Services
{
    public interface IBankingServices
    {
        void Deposit(int AccountId, double number);
        void Withdraw(int AccountId, double number);
        public AccountDto GetAccount(int AccountId);
    }
}
