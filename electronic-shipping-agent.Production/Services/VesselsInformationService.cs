using System.Text.Json;
using electronic_shipping_agent.Models;

namespace electronic_shipping_agent.Services;

public class VesselsInformationService
{
    // Option to disable deserialisation from being case sensitive
    private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

    // Decodes the JSON data into a VesselsInformation object
    public VesselsInformation DecodeVesselsInformation(string jsonData)
    {
        try
        {
            var vesselsInformation = JsonSerializer.Deserialize<VesselsInformation>(jsonData, _options);
            return vesselsInformation;
        }
        catch (Exception ex)
        {
            // TODO: Missing proper error handling
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
