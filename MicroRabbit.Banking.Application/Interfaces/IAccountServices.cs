using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountServices
    {
        IEnumerable<Account> Get();
        void Transfer(AccountTransfer accountTransfer);
    }
}
