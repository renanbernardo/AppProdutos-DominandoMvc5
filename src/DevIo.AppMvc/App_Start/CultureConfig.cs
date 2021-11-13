using System.Globalization;

namespace DevIo.AppMvc.App_Start
{
    public class CultureConfig
    {
        public static void RegisterCulture()
        {
            var culture = new CultureInfo("pr-BR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
        }
    }
}