using System.Data;
using System.Globalization;
using WebapiCalculator.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/calculate", (Operation operation) =>
{

    CalcultatorRPN _calculator = new CalcultatorRPN();

    string response = _calculator.Calculate(operation.operation);

    if (response.Contains("Error"))
    {
        return Results.NotFound(response);
    }


    return Results.Ok(response);

});

app.Run();


public class Operation
{
    public string operation { get; set; } = "";
}