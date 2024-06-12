using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Services
{
    public class Utilitys
    {

        public string GetEmployeeNumber()
        {
            string MissionEmployeeNumber = "test";
            //this method excutes stored procedure GetMissionLocations

            //then returns the MissionEmployeeNumber 
            return MissionEmployeeNumber;
        }

        public string GetEmployeeData(string CustomerData)
        {
            var PestEmployeeData = JsonConvert.DeserializeObject<TestApp.Common.Constants.EmployeeData>(CustomerData);
            return PestEmployeeData;
        }

        public Tuple<string, string> GetAuthTokenAndKey(string MissionEmployeeNumber)
        {

            string authToken = "your_auth_token";
            string authKey = "your_auth_key";
            //this method excutes stored procedure GetAuthKeyAndToken

            //then returns the token and key 
            return new Tuple<string, string>(authToken, authKey);

        }

    }
}
