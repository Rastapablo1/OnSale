using System.Globalization;

namespace OnSale.Commom.Helpers
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }

}
