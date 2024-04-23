using electronic_shipping_agent.Models;
using electronic_shipping_agent.Services;
using Microsoft.AspNetCore.Mvc;

namespace electronic_shipping_agent.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VesselsController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly VesselsInformationService _vesselsInformationService;

    private VesselsInformation _vesselsInformation;
    
    // Initialise private variables
    public VesselsController()
    {
        _httpClient = new HttpClient();
        _vesselsInformationService = new VesselsInformationService();
        _vesselsInformation = new VesselsInformation();
    }

    // Recieve method, gets the vessels information from the API endpoint, and decodes it
    [HttpGet("recieve")]
    public async Task<IActionResult> RecieveVesselInformation()
    {
        try
        {   
            // Get the HTTP response from the API endpoint, thow exception if not successful
            HttpResponseMessage response = await _httpClient.GetAsync("https://esa.instech.no/api/fleets/random");
            response.EnsureSuccessStatusCode();
            
            // Serialise the HTTP content into a string
            string responseBody = await response.Content.ReadAsStringAsync();

            // Decoode JSON string into VesselsInformation object
            _vesselsInformation = _vesselsInformationService.DecodeVesselsInformation(responseBody);
            
            return Ok(_vesselsInformation);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
