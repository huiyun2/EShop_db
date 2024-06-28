namespace ApplicationCore.Entities
{
    public class ShipperRegion
    {
        public int RegionId { get; set; }
        public int ShipperId { get; set; }

        public virtual Region Region { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
