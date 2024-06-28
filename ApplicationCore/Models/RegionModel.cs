namespace ApplicationCore.Models
{
    public class RegionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ShipperRegionModel> ShipperRegions { get; set; }
    }
}
