
namespace electronic_shipping_agent.Models
{
    public class VesselsInformation
    {
        public class Dimensions {
            public int width { get; set;}
            public int height { get; set;}
        }

        public class Fleet {
            public Dimensions singleShipDimensions { get; set;}
            public string shipDesignation { get; set;}
            public int shipCount { get; set;}
        }

        public Dimensions anchorageSize { get; set;}
        public Fleet[] fleets { get; set;}
    }
}