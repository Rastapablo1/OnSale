using OnSale.Commom.Requests;
using OnSale.Commom.Responses;
using System.Threading.Tasks;

namespace OnSale.Commom.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
        Task<Response> GetTokenAsync(string urlBase, string servicePrefix, string controller, TokenRequest request);
        Task<Response> PostQualificationAsync(string urlBase, string servicePrefix, string controller, QualificationRequest qualificationRequest, string token);
        Task<Response> RegisterUserAsync(string urlBase, string servicePrefix, string controller, UserRequest userRequest);
        Task<Response> RecoverPasswordAsync(string urlBase, string servicePrefix, string controller, EmailRequest emailRequest);
        Task<Response> ModifyUserAsync(string urlBase, string servicePrefix, string controller, UserRequest userRequest, string token);
        Task<Response> ChangePasswordAsync(string urlBase, string servicePrefix, string controller, ChangePasswordRequest changePasswordRequest, string token);
        Task<Response> PostAsync<T>(string urlBase, string servicePrefix, string controller, T model, string token);
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller, string token);
        Task<Response> PutAsync<T>(string urlBase, string servicePrefix, string controller, T model, string token);

    }
}
