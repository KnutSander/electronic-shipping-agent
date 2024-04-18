
using electronic_shipping_agent.Models;

namespace electronic_shipping_agent.Services;

public class Anchorage
{
    public Dimensions Dimensions { get; set; }
    public List<Dimensions> Vessels { get; set; } = new List<Dimensions>();
}

public class VesselsLayoutService
{
    // Variables here

    public VesselsLayoutService()
    {
        // Maybe split the VesselsInformation into seperate objects here?
    }

    //public List<Anchorage> FirstFit(VesselsInformation vesselsInformation)
    public void FirstFit(VesselsInformation vesselsInformation)
    {
        // Get anchorage height and width
        var AnchorageHeight = vesselsInformation.AnchorageSize.Height;
        var AnchorageWidth = vesselsInformation.AnchorageSize.Width;

        // Rounds stored as a list of Anchorages
        var rounds = new List<Anchorage>();

        // Transform Fleets into individual vessels
        // Sort the list by ship size
        var vessels = vesselsInformation.Fleets
        .SelectMany(fleet => Enumerable.Repeat(fleet.SingleShipDimensions, fleet.ShipCount))
        .OrderByDescending(vessel => vessel.Width * vessel.Height)
        .ToList();

        vessels.ForEach(vessel => Console.WriteLine(vessel.Width + " " + vessel.Height + " = " + (vessel.Width * vessel.Height)));
    }
}