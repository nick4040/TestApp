using System;

namespace TestAppp.Common { 
    public partial class Constants
    {

        public class SpotData
        {
            public string SpotID { get; set; }
            public string RouteID { get; set; }
            public string Date { get; set; }
            public string Start { get; set; }
            public string End { get; set; }
            public string SpotCapacity { get; set; }
            public string Description { get; set; }
            public string BlockReason { get; set; }
            public string CurrentAppointment { get; set; }
            public string CurrentAppointmentDuration { get; set; }
            public string DistanceToPrevious { get; set; }
            public string PreviousLat { get; set; }
            public string PreviousLng { get; set; }
            public string PrevSpotID { get; set; }
            public string ApiCanSchedule { get; set; }
            public string DistanceToNext { get; set; }
            public string NextLat { get; set; }
            public string NextLng { get; set; }
            public string NextCustomer { get; set; }
            public string NextSpotID { get; set; }
            public string Open { get; set; }
        }


    }
}
