namespace UrbanExplorerAPI.Models
{
    public class Location
    {
        public int Id { get; set; }
        public double Longtitude { get; set; }
        public double Latitude { get; set; }
        public string? Information { get; set; }
        public int Rating { get; set; }
        public bool Checked { get; set; }
    }
}
