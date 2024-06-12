using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace TestApp.Services
{

	public class NewCustomerHandler
	{

        public string PRcustomerID = "";

        public async Task<string> CreateNewCustomer(String CustomerData)
        {

            string Url = "";

            var PestCustomerData = JsonConvert.DeserializeObject<TestApp.Common.Constants.CustomerData>(CustomerData);

            var parameters1 = new Dictionary<string, object>
            {
                {"Branch", "AF" },
                {"CustomerAddress", PestCustomerData.Address },
                {"CustomerCity", PestCustomerData.City },
                {"CustomerEmail", PestCustomerData.Email },
                {"CustomerId", PestCustomerData.CustomerID },
                {"CustomerName", PestCustomerData.FName + PestCustomerData.LName},
                {"CustomerPhone1", PestCustomerData.Phone1 },
                {"CustomerPhone2", "" },
                {"CustomerState", PestCustomerData.State },
                {"CustomerStatus", "Act" },
                {"CustomerZipCode", PestCustomerData.Zip },
            };

            var CreateCustomerResponse = await TestApp.Services.ApiMethods.PostAsync(parameters1, Url);

            var CustomerResponse = JsonConvert.DeserializeObject<TestApp.Common.Constants.RequestLog>(CreateCustomerResponse);
            PRcustomerID = CustomerResponse.CustomerIDs;
            CustomerResponse = JsonConvert.DeserializeObject<TestApp.Common.Constants.CustomerData>(CreateCustomerResponse);


            return CustomerResponse;
        }

        public async Task<string> ProcessNewCustomer(string CustomerData)
        {
            var PestCustomerData = JsonConvert.DeserializeObject<TestApp.Common.Constants.CustomerData>(CustomerData);
            var PestEmployeeData = JsonConvert.DeserializeObject<TestApp.Common.Constants.EmployeeData>(CustomerData);

            var parameters1 = new Dictionary<string, object>
            {
                {"Branch", PestEmployeeData.AssignedBranch },
                {"CustomerAddress", PestCustomerData.Address },
                {"CustomerCity", PestCustomerData.City },
                {"CustomerId", PestCustomerData.CustomerID },
                {"CustomerPhone1", PestCustomerData.Phone1 },
                {"CustomerState", PestCustomerData.State },
                {"CustomerZipCode", PestCustomerData.Zip },
            };

            //excute a stored producdure to add customer to the customer database 

            var parameters2 = new Dictionary<string, object>
            {
                {"CustomerID", PRcustomerID },
                {"CustomerName", PestEmployeeData.CustomerName },
                {"CustomerNumber", PestEmployeeData.CustomerNumber },
                {"WorkOrderId", PestEmployeeData.WorkOrderActivityId},
            };

            //Map terminix Id to CustomerName and Pr CustomerId

            var parameters3 = new Dictionary<string, object>
            {
                {"WorkOrderId", PestEmployeeData.WorkOrderActivityId },
            };

            //get workorderid and return sheduled time back 
            string ScheduledDate = "";

            return ScheduledDate;
        }
    }
}
