using MicroRabbit.MVC.Models.DTO;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public interface ITransferServices
    {
        Task Transfer(TransferDto transferDto);
    }
}
