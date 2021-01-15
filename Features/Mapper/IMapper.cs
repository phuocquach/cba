using CBA.Features.Entity;
using CBA.Features.Services;

namespace CBA.Features.Mapper
{
    public interface IMapper
    {
        AccountDto Map(Account account);
    }
}
