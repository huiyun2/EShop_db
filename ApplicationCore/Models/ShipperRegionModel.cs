namespace ApplicationCore.Models
{
    public class ShipperRegionModel
    {
        public int RegionId { get; set; }
        public int ShipperId { get; set; }

        public RegionModel Region { get; set; }
        public ShipperModel Shipper { get; set; }
    }
}
