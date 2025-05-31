namespace DWC_Desktop.Http.Dto.Reports
{
    public class CreateReportRequest
    {
        public string temperature { get; set; }
        public int PH {  get; set; }
        public int impurities { get; set; }
        public int chlorine_level { get; set; }
        public int address_id { get; set; }
    }
}
