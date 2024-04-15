
using System.Text.Json;
using electronic_shipping_agent.Models;

namespace electronic_shipping_agent.Services
{
    public class VesselsInformationService
    {
        public VesselsInformation DecodeVesselsInformation (string jsonData)
        {
            try 
            {
                var vesselsInformation = JsonSerializer.Deserialize<VesselsInformation>(jsonData)!;
                return vesselsInformation;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}