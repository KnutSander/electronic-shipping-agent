
namespace electronic_shipping_agent.Models;

public class Dimensions
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

public class VesselsInformation
{
    public class Fleet
    {
        public Dimensions SingleShipDimensions { get; set; }
        public string ShipDesignation { get; set; }
        public int ShipCount { get; set; }
    }

    public Dimensions AnchorageSize { get; set; }
    public Fleet[] Fleets { get; set; }
}
