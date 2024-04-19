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
    private readonly VesselsLayoutService _vesselsLayoutService;

    private VesselsInformation _vesselsInformation;
    

    public VesselsController()
    {
        _httpClient = new HttpClient();
        _vesselsInformationService = new VesselsInformationService();
        _vesselsLayoutService = new VesselsLayoutService();
        _vesselsInformation = new VesselsInformation();
    }

    [HttpGet("recieve")]
    public async Task<IActionResult> RecieveVesselInformation()
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://esa.instech.no/api/fleets/random");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            //Decoode JSON into object
            _vesselsInformation = _vesselsInformationService.DecodeVesselsInformation(responseBody);

            // Calculate optimal layout
            _vesselsLayoutService.FirstFit(_vesselsInformation);
            
            return Ok(_vesselsInformation);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
