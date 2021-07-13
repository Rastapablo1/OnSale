using OnSale.Commom.Responses;

namespace Onsale.Web.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
        
    }

}
