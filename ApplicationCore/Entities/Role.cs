namespace ApplicationCore.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ShipperRegion> ShipperRegions { get; set; }
    }
}
