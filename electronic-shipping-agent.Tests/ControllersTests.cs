
using electronic_shipping_agent.Controllers;

namespace electronic_shipping_agent.Tests;

public class VesselsControllerTest
{
    [Fact]
    public async Task RecieveVesselInformation_ReturnsNotNull()
    {
        var controller = new VesselsController();

        var result = await controller.RecieveVesselInformation();

        Assert.NotNull(result);
    }

    //TODO: More tests here
}

//TODO: Tests for more services here