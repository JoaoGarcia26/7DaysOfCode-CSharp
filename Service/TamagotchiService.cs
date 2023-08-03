using _7DaysOfCode_C_.Models;
using RestSharp;
using System.Text.Json;

namespace _7DaysOfCode_C_.Service;

internal class TamagotchiService
{
    public Mascote InvocarGet(string endpoint)
    {
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{endpoint}");
        var request = new RestRequest("", Method.Get);
        var response = client.Execute(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var mascote = JsonSerializer.Deserialize<Mascote>(response.Content!)!;
            return mascote;
        }
        else
        {
            throw new NotImplementedException(response.ErrorMessage);
        }
    }
}
