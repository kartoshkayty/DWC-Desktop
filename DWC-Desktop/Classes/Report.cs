using System;

namespace DWC_Desktop.Classes
{
    public class Report
    {
        public int id { get; set; }
        public float temperature { get; set; }
        public int PH {  get; set; }
        public int chlorine_level { get; set; }
        public int impurities { get; set; }
        public DateTime created_at { get; set; }
        public Address address { get; set; }
    }
}
