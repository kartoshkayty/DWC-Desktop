using System;
using System.Collections.Generic;

namespace DWC_Desktop.Http.Dto
{
    public class HttpError : SystemException
    {
        public List<string> message {  get; set; }
        public string error { get; set; }
        public int statusCode {  get; set; }
    }
}
