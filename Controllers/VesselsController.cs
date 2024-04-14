using Microsoft.AspNetCore.Mvc;

namespace electronic_shipping_agent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VesselsController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public VesselsController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet("recieve")]
        public async Task<IActionResult> RecieveVesselInformation()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://esa.instech.no/api/fleets/random");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return Ok(responseBody);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}