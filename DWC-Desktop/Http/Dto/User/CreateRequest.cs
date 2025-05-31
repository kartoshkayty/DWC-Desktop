using DWC_Desktop.Enums;

namespace DWC_Desktop.Http.Dto.User
{
    public class CreateRequest
    {
        public string email {  get; set; }
        public Role role { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
