using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using Newtonsoft.Json;

class Program
{
     async Task Main(string[] args)
    {

        string authKey = "";
        string authToken = "";
        string Url = "https://665898a25c361705264923dc.mockapi.io/test/api/Customer";

        string EmployeeNumber = TestApp.Services.Utilitys.GetEmployeeNumber();

        var AuthKeyToken = TestApp.Services.Utilitys.GetAuthTokenAndKey(EmployeeNumber);

        authToken = AuthKeyToken.Item1;
        authKey = AuthKeyToken.Item2;
        
        var TermCustomer = await TestApp.Services.CustomerDataHandler.GetCustomerData(Url, string EmployeeNumber);

        var cleanCustomerData = TestApp.Services.CustomerDataHandler.FilterCustomerData(TermCustomer);

        string CustomerNumber = cleanCustomerData.Item1;
        string ScheduledDate = cleanCustomerData.Item2;

        var PestCustomer = await TestApp.Services.CustomerDataHandler.GetPestRoutesCustomerData(Url, )



    }






}







