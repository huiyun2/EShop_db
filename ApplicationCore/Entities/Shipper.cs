namespace ApplicationCore.Entities
{
    public class Shipper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }

        public virtual ICollection<ShipperRegion> ShipperRegions { get; set; }
    }
}
