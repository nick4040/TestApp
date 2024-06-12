using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Services
{
    public class CustomerDataHandler
    {

        public Tuple<string, string> FilterCustomerData(String CustomerData)
        {

            var CleanCustomerData = JsonConvert.DeserializeObject<List<TestApp.Common.Constants.CustomerData>>(CustomerData);

            string CustomerNumber = "";
            string Scheduledata = "";

            foreach (var customer in CleanCustomerData)
            {
                CustomerNumber = customer.CustomerId;
                Scheduledata = customer.ScheduledToData;

                //we would then send more customer data to excute insertWorkOrder
            }

            return new Tuple<string, string>(CustomerData, Scheduledata);
        }

        public async Task<string> GetTerminixCustomerData(string MissionEmployeeNumber)
        {
            DateTime utcNowTD = DateTime.UtcNow; // Gets the current date and time in UTC
            DateTime adjustedTimeTD = utcNowTD.AddHours(5).AddDays(14); // Adds 5 hours and 14 days
            string ScheduledToDate = adjustedTimeTD.ToString("MM/dd/yyyy"); // Formats the date as MM/dd/yyyy

            DateTime utcNowFD = DateTime.UtcNow; // Gets the current date and time in UTC
            DateTime adjustedTimeFD = utcNowFD.AddHours(5); // Adds 5 hours
            string ScheduledFromDate = adjustedTimeFD.ToString("MM/dd/yyyy"); // Formats the date as MM/dd/yyyy

            string terminixToken = TestApp.Common.Constants.terminixToken;//gets the terminix key and token
            string terminixKey = TestApp.Common.Constants.terminixKey;

            var parameters1 = new Dictionary<string, object> //passes the 3 vars to the parameter
            {
                { "MissionEmployee", MissionEmployeeNumber },
                { "ScheduledFromData", ScheduledFromDate},
                { "ScheduledToData", ScheduledToDate},
            };

            string url = "";

            var CustomerData = TestApp.Services.ApiMethods.PostAsync(parameters1, url);//Post the parameter to the url 
            // need to make another method to take terminix token and key
            return CustomerData;//return response 
        }

        public async Task<string> GetPestRoutesCustomerData(string CustomerNumber)
        {
            string Url = "";

            var parameters1 = new Dictionary<string, object>
            {
                {"CustomerNumber", CustomerNumber}
            };

            //searches to see if the customer already exists 
            var CustomerData = TestApp.Services.ApiMethods.PostAsync(parameters1, Url);

            //returns json data not mapped data
            return CustomerData;
            
        }

        public string DoesCustomerHaveAppointmentData(string CustomerData)
        {
            var PestCustomerData = JsonConvert.DeserializeObject<TestApp.Common.Constants.CustomerData>(CustomerData);

            TestApp.Services.NewCustomerHandler.PRcustomerID = PestCustomerData.CustomerId;

            string results = "";

            if (PestCustomerData.AppointmentIDs.Equals(null))
            {
                return results = "0";
            }
            return results = "1";
        }

        public string CheckIfCustomerExistsDB(string CustomerData)
        {

            var PestCustomerData = JsonConvert.DeserializeObject<TestApp.Common.Constants.CustomerData>(CustomerData);

            var parameters1 = new Dictionary<string, object>
            {
                {"CustomerNumber", PestCustomerData.CustomerId }
            }

            // we will check if the customer exists in the DB if customer exists return 1 if not return 0 

        }
    }
}
