﻿namespace TestApp.Common
//any that needs to be shared interfaces, models, extenision methods, enums, constants 
{
    public partial class Constants
    {
        public class EmployeeData
        {
            public int WorkOrderActivityId { get; set; }
            public string SalesAgreementNumber { get; set; }
            public int CustomerNumber { get; set; }
            public string CustomerName { get; set; }
            public int ScheduleDateYYYYMMDD { get; set; } 
            public DateTime ScheduleDate { get; set; }
            public string ScheduleFromTimeHHMM24Hr { get; set; }
            public string ScheduleTillTimeHHMM24Hr { get; set; }
            public string ScheduledEmployee { get; set; }
            public string ScheduledEmployeeName { get; set; }
            public string ServiceLine { get; set; }
            public string AssignedBranch { get; set; }
            public string MarketType { get; set; }
            public string AssignedRegion { get; set; }
            public string AssignedDivision { get; set; }
            public string WorkOrderStatus { get; set; }
            public string PhoneNumber { get; set; }
            public string ItemCode { get; set; }
            public double CubicFeet { get; set; }
            public string ScheduleStatus { get; set; }
            public int LastUpdatedDateGMTYYYYMMDD { get; set; } 
            public TimeSpan LastUpdatedTimeGMTHHMMSS { get; set; }
            public string ServiceAddress { get; set; }
        }

    }
}
