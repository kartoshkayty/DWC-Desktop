using DWC_Desktop.Enums;

namespace DWC_Desktop.Classes
{
    public class User
    {
        public Role role { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int id { get; set; }
    }
}
