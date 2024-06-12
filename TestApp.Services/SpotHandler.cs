using System;

namespace TestApp.Services
{

    public class SpotHandler
    {


        public async SpotSearch(string ScheduledDate)
        {
            string Url = "";

            DateTime parsedDate = DateTime.Parse(ScheduledDate);

            string startDate = parsedDate.ToString("yyyy-MM-dd");
            string endDate = parsedDate.AddDays(1).ToString("yyyy-MM-dd")

            var parameters1 = new Dictionary<string, object>
            {
                {"Date", $"{{\"operator\":\"Between\",\"value\":[\"{startDate}\",\"{endDate}\"]}}"},
            };

            var SpotSearchResults = TestApp.Services.ApiMethods.PostAsync(parameters1, Url);
            string FormatedSpotId = FormatSpot(SpotSearchResults);

            return FormatedSpotId;
        }

        public Task<string> FormatSpot(String SpotSearchResults)
        {
            var CleanSpotData = JsonConvert.DeserializeObject<TestApp.Common.Constants.SpotData>(SpotSearchResults);

            //then Insert the SpotData into the database 

            //after that we will then get the spotId from the database 

            string SpotID = "";

            return SpotID;
        }
    }
}
