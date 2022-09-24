using System.ComponentModel.DataAnnotations;
namespace CTFMuenster.Api.Model{
    public class Location {
        [Key]
        public Guid Id {get; set;}
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double longitude, double latitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}