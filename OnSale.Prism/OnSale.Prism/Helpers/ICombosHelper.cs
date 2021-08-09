using OnSale.Commom.Models;
using System.Collections.Generic;

namespace OnSale.Prism.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<PaymentMethod> GetPaymentMethods();
    }
}
