using System;
using System.Collections.Generic;
using System.Linq;

namespace CBA.Features.Entity
{
    public class Bank
    {
        private readonly ICollection<Account> _accounts;
        public Bank()
        {
            _accounts = new List<Account>
            {
                new Account
                {
                    Id = 1,
                    Name = "First User"
                }
            };

        }

        public Account GetAccount(int id)
        {
            return _accounts.FirstOrDefault(x => x.Id == id);
        }

    }
}
