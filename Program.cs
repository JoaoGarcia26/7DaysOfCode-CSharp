using _7DaysOfCode_C_.Models;
using RestSharp;
using System.Text.Json;

static void InvocarGet(string endpoint)
{
    var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{endpoint}");
    var request = new RestRequest("", Method.Get);
    var response = client.Execute(request);
    
    if (response.StatusCode == System.Net.HttpStatusCode.OK)
    {
        Console.WriteLine(response.Content);
    } else
    {
        Console.WriteLine(response.ErrorMessage);
    }
}

InvocarGet("pikachu");



