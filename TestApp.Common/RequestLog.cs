namespace TestApp.Common
//any that needs to be shared interfaces, models, extenision methods, enums, constants 
{
    public partial class Constants
    {
       
        public class RequestLog
        {
            public string RequestAction { get; set; }
            public string Endpoint { get; set; }
            public bool Success { get; set; }
            public string IdName { get; set; }
            public double ProcessingTime { get; set; }
            public int Count { get; set; }
            public List<int> CustomerIDs { get; set; }
            public string PropertyName { get; set; }
            public List<int> CustomerIDsNoDataExported { get; set; }
            public List<Customer> Customers { get; set; }
            public string PropertyNameData { get; set; }
        }


    }
}
