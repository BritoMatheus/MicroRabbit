using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferServices
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:44302/api/banking";
            var transferContent = new StringContent(
                JsonConvert.SerializeObject(transferDto),
                System.Text.Encoding.UTF8,
                "application/json");
            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
