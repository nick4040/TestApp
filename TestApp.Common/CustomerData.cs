namespace TestApp.Common
//any that needs to be shared interfaces, models, extenision methods, enums, constants 
{
    public partial class Constants
    {
        public class CustomerData
        {
            public int CustomerID { get; set; }
            public int BillToAccountID { get; set; }
            public int OfficeID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string CompanyName { get; set; }
            public string Spouse { get; set; }
            public bool CommercialAccount { get; set; }
            public string Status { get; set; }
            public string StatusText { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Phone2 { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string BillingCompanyName { get; set; }
            public string BillingFName { get; set; }
            public string BillingLName { get; set; }
            public int BillingCountryID { get; set; }
            public string BillingAddress { get; set; }
            public string BillingCity { get; set; }
            public string BillingState { get; set; }
            public string BillingZip { get; set; }
            public string BillingPhone { get; set; }
            public string BillingEmail { get; set; }
            public double Lat { get; set; }
            public double Lng { get; set; }
            public double SquareFeet { get; set; }
            public int AddedByID { get; set; }
            public DateTime DateAdded { get; set; }
            public DateTime? DateCancelled { get; set; }
            public DateTime DateUpdated { get; set; }
            public int SourceID { get; set; }
            public string Source { get; set; }
            public double APay { get; set; }
            public int PreferredTechID { get; set; }
            public bool PaidInFull { get; set; }
            public List<int> SubscriptionIDs { get; set; }
            public double Balance { get; set; }
            public int BalanceAge { get; set; }
            public double ResponsibleBalance { get; set; }
            public int ResponsibleBalanceAge { get; set; }
            public string CustomerLink { get; set; }
            public bool MasterAccount { get; set; }
            public int PreferredBillingDate { get; set; }
            public DateTime? PaymentHoldDate { get; set; }
            public string MostRecentCreditCardLastFour { get; set; }
            public DateTime? MostRecentCreditCardExpirationDate { get; set; }
            public List<int> AppointmentIDs { get; set; }
            public List<int> TicketIDs { get; set; }
            public List<int> PaymentIDs { get; set; }
        }

    }
}
