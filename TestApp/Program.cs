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
using System.Reflection.Metadata;

class Program
{
     async Task Main(string[] args)
    {


        string Url = "https://665898a25c361705264923dc.mockapi.io/test/api/Customer";

        string EmployeeNumber = TestApp.Services.Utilitys.GetEmployeeNumber();//gets the employee Number
        
        var TermCustomer = await TestApp.Services.CustomerDataHandler.GetCustomerData(Url, string EmployeeNumber);//gets Terminix CustomerData

        var cleanCustomerData = await TestApp.Services.CustomerDataHandler.FilterCustomerData(TermCustomer);//Returns filitered data 

        string CustomerNumber = cleanCustomerData.Item1;
        string ScheduledDate = cleanCustomerData.Item2;

        var PestCustomer = await TestApp.Services.CustomerDataHandler.GetPestRoutesCustomerData(CustomerNumber);//Get pestpack customer data with CustomerNumber
            //check to see if the customer exists 
        if (PestCustomer.Length > 0)
        {
                //true customer exists 
            string CustomerResults = TestApp.Services.CustomerDataHandler.CheckIfCustomerExistsDB(PestCustomer);// check to see if the user is in the DB 
            if (CustomerResults.Equals("1"))//if 1 then user exists 
            {
          
                string DoesCustomerHaveAppointment = TestApp.Services.CustomerDataHandler.DoesCustomerHaveAppointmentData(PestCustomer);//Stores PR customerID and checks if they have a appointmentID
                if (DoesCustomerHaveAppointment.Equals("1"))// if 1 then the customer has a appointmentID 
                {

                    string SpotId1 = TestApp.Services.SpotHandler.SpotSearch(ScheduledDate); // we take the scheduled time and find a new spot
                    var AppointmentData1 = TestApp.Services.AppointmentHandler.CreateAppointment(SpotId1); // we then take our new spot and create a appointment
                    var WorkOrderData = TestApp.Services.Utilitys.GetEmployeeData() // we then grab the workorderID 
                    TestApp.Services.AppointmentHandler.UpdateAppointmentByWorkOrder(AppointmentData1, WorkOrderData) //We then take the AppID and WorkOrderID and add it to the DB
               
                } else
                {

                }

            } else
            {
                // if string = 0 then  the user does not exists
            }

        } else
        {
            //false customer does not exist 
            var NewPestCustomer = await TestApp.Services.NewCustomerHandler.CreateNewCustomer(PestCustomer);//creates new customer 
            string ScheduledDate = TestApp.Services.NewCustomerHandler.ProcessNewCustomer(NewPestCustomer);// updates database and returns scheduled time
            string SpotId2 = TestApp.Services.SpotHandler.SpotSearch(ScheduledDate); // we then find a new spot and updates the database then returns the spotID
            var AppointmentData2 = TestApp.Services.AppointmentHandler.CreateAppointment(SpotId2);// calls createAppointment and makes the appoinment 
            TestApp.Services.AppointmentHandler.UpdateAppointmentById(AppointmentData2); // final step is to update the appointment in the database 
        }

    }






}







