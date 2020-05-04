using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountServices(IAccountRepository accountRepository,
            IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> Get()
        {
            return _accountRepository.Get();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount);
            _bus.SendCommand(createTransferCommand);
        }
    }
}
