using CBA.Features.Entity;
using CBA.Features.Services;

namespace CBA.Features.Mapper
{
    public class Mapper : IMapper
    {
        public AccountDto Map(Account request)
        {
            return new AccountDto
            {
               Balance = request.Balance,
               Id = request.Id,
               Name = request.Name
            };
        }
    }
}
