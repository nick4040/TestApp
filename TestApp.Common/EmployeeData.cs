namespace TestApp.Common
//any that needs to be shared interfaces, models, extenision methods, enums, constants 
{
    public partial class Constants
    {
        public class EmployeeData
        {
            public string MissionId { get; set; }
            public string EmployeeNumber { get; set; }
            public string EmployeeJDENumber { get; set; }
            public string EmployeeName { get; set; }
            public string JobCode { get; set; }
            public string BranchCode { get; set; }
            public string BranchName { get; set; }
            public string RegionCode { get; set; }
            public string RegionName { get; set; }
            public string DivisionCode { get; set; }
            public string DivisionName { get; set; }
            public string EmployeeStatus { get; set; }
            public string EmployeeRole { get; set; }
            public string EmployeeRoleName { get; set; }
            public string EmployeeBranchName { get; set; }
            public string BUType { get; set; }
            public string TicketID { get; set; }
            public string ReturnMessage { get; set; }
            public List<MetricsAccessTo> MetricsAccessTo { get; set; }
        }

    }
}
