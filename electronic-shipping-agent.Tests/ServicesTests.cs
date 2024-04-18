using Xunit;
using electronic_shipping_agent.Services;

public class VesselsInformationServiceTests
{
    [Fact]
    public void DecodeVesselsInformation_ReturnsNotNull()
    {
        var service = new VesselsInformationService();
        var jsonData = "{\"anchorageSize\":{\"width\":12,\"height\":15},\"fleets\":[{\"singleShipDimensions\":{\"width\":6,\"height\":5},\"shipDesignation\":\"LNG Unit\",\"shipCount\":2},{\"singleShipDimensions\":{\"width\":3,\"height\":12},\"shipDesignation\":\"Science & Engineering Ship\",\"shipCount\":5}]}";
        
        var result = service.DecodeVesselsInformation(jsonData);

        Assert.NotNull(result);
    }

    //TODO: More tests here
}

//TODO: Tests for more services here