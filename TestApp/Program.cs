using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {

        string authKey = "";
        string authToken = "";

        string EmployeeNumber = GetEmployeeNumber();

        var AuthKeyToken = GetAuthTokenAndKey(EmployeeNumber);

        authToken = AuthKeyToken.Item1;
        authKey = AuthKeyToken.Item2;
        
        var Customer = await GetCustomerData("https://665898a25c361705264923dc.mockapi.io/test/api/Customer", authToken, authKey, EmployeeNumber);

        var cleanCustomerData = FilterCustomerData(Customer);
        
    }

    public static string GetEmployeeNumber()
    {
        string MissionEmployeeNumber = "test";
        //this method excutes stored procedure GetMissionLocations

        //then returns the MissionEmployeeNumber 
        return MissionEmployeeNumber;
    }

    public static Tuple<string, string> GetAuthTokenAndKey(string MissionEmployeeNumber)
    {

        string authToken = "your_auth_token";
        string authKey = "your_auth_key";
        //this method excutes stored procedure GetAuthKeyAndToken

        //then returns the token and key 
        return new Tuple<string, string>(authToken, authKey);

    }

    public static Task<string> GetCustomerData(string url, string terminixToken, string terminixKey, string MissionEmployeeNumber)
    {
        DateTime utcNowTD = DateTime.UtcNow; // Gets the current date and time in UTC
        DateTime adjustedTimeTD = utcNowTD.AddHours(5).AddDays(14); // Adds 5 hours and 14 days
        string ScheduledToDate = adjustedTimeTD.ToString("MM/dd/yyyy"); // Formats the date as MM/dd/yyyy

        DateTime utcNowFD = DateTime.UtcNow; // Gets the current date and time in UTC
        DateTime adjustedTimeFD = utcNowFD.AddHours(5); // Adds 5 hours
        string ScheduledFromDate = adjustedTimeFD.ToString("MM/dd/yyyy"); // Formats the date as MM/dd/yyyy

        terminixToken = TestApp.Common.Constants.terminixToken;//gets the terminix key and token
        terminixKey = TestApp.Common.Constants.terminixKey;

        var parameters1 = new Dictionary<string, object> //passes the 3 vars to the parameter
            {
                { "MissionEmployee", MissionEmployeeNumber },
                { "ScheduledFromData", ScheduledFromDate},
                { "ScheduledToData", ScheduledToDate},
            };

        var CustomerData = TestApp.Services.ApiMethods.PostAsync(parameters1, url, terminixToken, terminixKey);//Post the parameter to the url 

        return CustomerData;//return response 
    }

    public static Tuple<string, string> FilterCustomerData(String CustomerData)
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
}







