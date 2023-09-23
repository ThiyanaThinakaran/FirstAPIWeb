// See https://aka.ms/new-console-template for more information
using WebApiClientConsole;

Console.WriteLine("APICLIENT!");
EmployeeAPIClient.CallGetAllEmployeeJson().Wait();
Console.ReadLine();
