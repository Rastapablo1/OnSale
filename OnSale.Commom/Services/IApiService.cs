using OnSale.Commom.Requests;
using OnSale.Commom.Responses;
using System.Threading.Tasks;

namespace OnSale.Commom.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
        Task<Response> GetTokenAsync(string urlBase, string servicePrefix, string controller, TokenRequest request);
    }

}
