
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
public Dimensions SingleShipDimensions { get; set; } = new Dimensions();
public string ShipDesignation { get; set; } = "";
public int ShipCount { get; set; }
}

// VesselsInformatiuon class to store the entire input dataset
public class VesselsInformation
{
    public Dimensions AnchorageSize { get; set; } = new Dimensions();
    public Fleet[] Fleets { get; set; } = [];
}
