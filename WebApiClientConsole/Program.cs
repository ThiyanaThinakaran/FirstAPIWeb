// See https://aka.ms/new-console-template for more information
using WebApiClientConsole;



Console.WriteLine("API CLIENT!");
//EmployeeAPIClient.CallGetAllEmployee().Wait();
EmployeeAPIClient.AddNewEmployee().Wait();
EmployeeAPIClient.UpdateEmployee(9).Wait();

Console.ReadLine();