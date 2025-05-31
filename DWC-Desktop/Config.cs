using DWC_Desktop.Classes;

namespace DWC_Desktop
{
    public static class Config
    {
        public static string API_URL { get; set; }
        public static string Token { get; set; }
        public static User user { get; set; }

        public static void Init()
        {
            API_URL = "https://dwc-api.minecis.net/api";
        }
    }
}
