using System;

namespace TestApp.Services

public class AppointmentHandler
{
	public async Task<string> CreateAppointment(string SpotID)
	{
        var parameters1 = new Dictionary<string, object>
            {
                { "CustomerID", TestApp.Services.NewCustomerHandler.PRcustomerID },
                { "SpotID", SpotID},
                { "Type", 6},
            };

        string url = "";

        var Response = TestApp.Services.ApiMethods.PostAsync(parameters1, url); //we are creating the appointment to send to the api

        var AppointmentData = JsonConvert.DeserializeObject<TestApp.Common.Constants.AppointmentData>(Response);// we then map our response to AppointmentData

        return AppointmentData;
    }

    public string UpdateAppointmentById(string AppointmentData)
    {
        var parameters1 = new Dictionary<string, object>
        {
            { "AppointmentId", AppointmentData.AppointmentID },
            { "CustomerID", AppointmentData.CustomerID},
        };

        // we will then update the appointment in the database by the customerID
    }

    public string UpdateAppointmentByWorkOrder(string AppointmentData, string EmpolyData)
    {
        var parameters1 = new Dictionary<string, object>
        {
            { "AppointmentId", AppointmentData.AppointmentID },
            { "WorkOrderId", EmpolyData.WorkOrderActivityId },
        }; 

        //we will then update the appointment in the DB by workorder
    }
}
