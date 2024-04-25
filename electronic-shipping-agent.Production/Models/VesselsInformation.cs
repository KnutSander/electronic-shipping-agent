
namespace electronic_shipping_agent.Models;

// Dimensions class to store width and height, used by other classes
public class Dimensions
{
    public int Width { get; set; }
    public int Height { get; set; }
}

// Fleet class for all fleets in the input data
public class Fleet
{
public required Dimensions SingleShipDimensions { get; set; }
public required string ShipDesignation { get; set; }
public int ShipCount { get; set; }
}

// VesselsInformatiuon class to store the entire input dataset
public class VesselsInformation
{
    public required Dimensions AnchorageSize { get; set; }
    public required Fleet[] Fleets { get; set; }
}
