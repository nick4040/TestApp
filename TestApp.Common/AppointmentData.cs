using System;

namespace TestApp.Common
{

    public partial class Constants
    {
        public class AppointmentData
        {
        public int CustomerID { get; set; }
        public int Type { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int Duration { get; set; }
        public int EmployeeID { get; set; }
        public string Notes { get; set; }
        public int SpotID { get; set; }
        public int RouteID { get; set; }
        public int CallAhead { get; set; }
        public int AssignedTech { get; set; }
        public int SubscriptionID { get; set; }
        public int DoInterior { get; set; }
        public string TargetPests { get; set; }
        public int RejectOccupiedSpots { get; set; }
        public int RejectFixedOccupiedSpots { get; set; }
        public string Reservation { get; set; }
        public int BypassLockedRoute { get; set; }
        public int BypassSchedulePermission { get; set; }
        public int ServicedBy { get; set; }
        public int CompletedBy { get; set; }
        public int Sequence { get; set; }
        public int AppointmentID { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public int Status { get; set; }
        public int CancelledBy { get; set; }
        public int Lock { get; set; }
        public int LockedBy { get; set; }

        }

    }

}
