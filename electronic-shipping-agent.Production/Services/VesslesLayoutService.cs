
using electronic_shipping_agent.Models;

namespace electronic_shipping_agent.Services;

public class VesselsLayoutService
{
    // Variables here

    public VesselsLayoutService()
    {
        // Maybe split the VesselsInformation into seperate objects here?
    }

    //public List<Anchorage> FirstFit(VesselsInformation vesselsInformation)
    public int FirstFit(VesselsInformation vesselsInformation)
    {
        // First, extract Fleets as individual vessels
        var vessels = new List<Vessel>();

        // Transform Fleets into individual vessels
        foreach (var fleet in vesselsInformation.Fleets)
        {
            for (int i = 0; i < fleet.ShipCount; i++)
            {
                vessels.Add(new Vessel(fleet.SingleShipDimensions.Width, fleet.SingleShipDimensions.Height));
            }
        }

        // Sort list
        vessels = vessels.OrderByDescending(vessel => vessel.Width * vessel.Height).ToList();

        //vessels.ForEach(vessel => Console.WriteLine(vessel.Width + " " + vessel.Height + " = " + (vessel.Width * vessel.Height)));

        // Keep a list of the anchorages, it's length will be used to 
        var anchorages = new List<Anchorage>();

        // Iterate through each vessel until it is placed

        return 0;
    }
}