// Should use Dimensions class here as well

namespace electronic_shipping_agent.Models;

public class Anchorage
{
    public int Width { get; }
    public int Height { get; }
    public List<Vessel> Placements { get; } = new List<Vessel>();

    public Anchorage(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

public class Vessel
{
    public int Width { get; }
    public int Height { get; }
    public int X { get; set; }
    public int Y { get; set; }
    public bool Rotated { get; set; } = false;

    public Vessel(int width, int height)
    {
        Width = width;
        Height = height;
    }
}
